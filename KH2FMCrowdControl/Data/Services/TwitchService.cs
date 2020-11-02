using KH2FMCrowdControl.Twitch;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public class TwitchService
    {
        public static event UserCoinDelegate OnUserCoinsUpdated;
        public static event HostsDelegate OnHostsChanged;

        private readonly string redirectUriHost = "https://localhost:44362/crowdcontrolhost";
        private readonly string redirectUriViewer = "https://localhost:44362/crowdcontrolviewer";

        //private readonly string redirectUriHost = "https://memoryscape.azurewebsites.net/crowdcontrolhost";
        //private readonly string redirectUriViewer = "https://memoryscape.azurewebsites.net/crowdcontrolviewer";

        private readonly string twitchAuthLink = "https://id.twitch.tv/oauth2/authorize";

        public TwitchApi GetTwitchApi(string username)
        {
            return DbContext.Hosts[username].TwitchApi;
        }

        public int GetUsersCoins(string hostName, string viewerName)
        {
            if (DbContext.Hosts.ContainsKey(hostName) && DbContext.Hosts[hostName].TwitchApi.UserCoins.ContainsKey(viewerName))
                return DbContext.Hosts[hostName].TwitchApi.UserCoins[viewerName].Coins;
            else
                return 0;
        }

        public void SetUsersCoins(string hostName, string viewerName, int coins)
        {
            if (DbContext.Hosts.ContainsKey(hostName) && DbContext.Hosts[hostName].TwitchApi.UserCoins.ContainsKey(viewerName))
                DbContext.Hosts[hostName].TwitchApi.UserCoins[viewerName].Coins -= coins;
        }

        public string RedirectToCreateHost(string clientId)
        {
            return this.GetTwitchAuthenticationLink(clientId, redirectUriHost, "token");
        }

        public TwitchApi GetHost(string username)
        {
            if (!string.IsNullOrEmpty(username) && DbContext.Hosts.ContainsKey(username))
                return DbContext.Hosts[username].TwitchApi;

            return null;
        }

        // TODO Redo how hosting works
        public TwitchApi CreateHost(string username, string clientId, string connectionId, NavigationManager navigationManager)
        {
            var accessToken = this.GetTwitchAuthenticationToken(navigationManager);

            var twitchApi = new TwitchApi(clientId, accessToken);

            if (!DbContext.Hosts.ContainsKey(username.ToLower()))
                DbContext.Hosts.Add(username.ToLower(), null);

            if (DbContext.Hosts[username.ToLower()] != null)
            {
                DbContext.Hosts[username.ToLower()].TwitchApi = twitchApi;
                DbContext.Hosts[username.ToLower()].IsHosting = true;
            }
            else
                DbContext.Hosts[username.ToLower()] = new Host { ConnectionId = connectionId, IsHosting = true, TwitchApi = twitchApi };

            TwitchService.HostsUpdated(this, new ChangeEventArgs());

            return twitchApi;
        }

        public void RemoveHost(string username)
        {
            if (DbContext.Hosts.ContainsKey(username))
                DbContext.Hosts.Remove(username);

            TwitchService.HostsUpdated(this, new ChangeEventArgs());
        }

        public string RedirectToViewer(string username)
        {
            DbContext.Hosts.TryGetValue(username, out var host);

            var clientId = host.TwitchApi.api.Settings.ClientId;

            return this.GetTwitchAuthenticationLink(clientId, redirectUriViewer, "token");
        }

        public string GetTwitchAuthenticationLink(string clientId, string redirectUri, string tokenType)
        {
            return $"{twitchAuthLink}?client_id={clientId}&redirect_uri={redirectUri}&response_type={tokenType}&scope=chat:read";
        }

        public string GetTwitchAuthenticationToken(NavigationManager navigationManager)
        {
            return navigationManager.Uri.Split('#')[1].Split('&').FirstOrDefault(x => x.Split('=')[0].Equals("access_token")).Split('=')[1];
        }

        public async Task<TwitchUserInfo> GetUserInfo(NavigationManager navigationManager)
        {
            var accessToken = this.GetTwitchAuthenticationToken(navigationManager);

            var httpClient = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new System.Uri("https://id.twitch.tv/oauth2/validate"),
                Headers =
                {
                    { HttpRequestHeader.Authorization.ToString(), $"OAuth {accessToken}" },
                    { HttpRequestHeader.Accept.ToString(), "application/json" },
                    { "X-Version", "1" }
                }
            };

            var response = await httpClient.SendAsync(request);
            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<TwitchUserInfo>(json);
        }

        #region Events

        public static void UserCoinsUpdated(object sender, ChangeEventArgs e)
        {
            OnUserCoinsUpdated?.Invoke(sender, e);
        }

        public static void HostsUpdated(object sender, ChangeEventArgs e)
        {
            OnHostsChanged?.Invoke(sender, e);
        }

        #endregion Events
    }
}