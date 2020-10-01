﻿using KH2FMCrowdControl.Data;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Tasks;
using System.Timers;
using TwitchLib.Api;
using TwitchLib.Api.Core.Enums;

namespace KH2FMCrowdControl.Twitch
{
    public class TwitchApi
    {
        public Dictionary<string, TwitchUser> UserCoins;
        public readonly TwitchAPI api;

        private readonly Timer timer;

        private readonly HttpClient httpClient;
        private readonly string chatUrl;
        private readonly string username;

        public TwitchApi(string clientId, string accessToken)
        {
            this.httpClient = new HttpClient();

            this.api = new TwitchAPI();

            this.api.Settings.ClientId = clientId;
            this.api.Settings.AccessToken = accessToken;
            this.api.Settings.Scopes = new List<AuthScopes> { AuthScopes.Any };

            this.username = Task.Run(async () => await this.api.Helix.Users.GetUsersAsync()).Result.Users
                .Select(x => x.Login)
                .FirstOrDefault();


            this.UserCoins = new Dictionary<string, TwitchUser> { { username, new TwitchUser { Name = username, Coins = 50000 } } };

            this.chatUrl = $"https://tmi.twitch.tv/group/user/{username}/chatters";

            this.timer = new Timer(10000) { AutoReset = true };

            this.timer.Elapsed += this.SetupUserTracker;

            this.timer.Start();
        }

        private async void SetupUserTracker(object sender, ElapsedEventArgs e)
        {
            var response = await httpClient.GetAsync(chatUrl);

            var users = JsonSerializer.Deserialize<TwitchChatInfo>(await response.Content.ReadAsStringAsync()).chatters;

            // TODO What if the user navigates to the site without first being added here?

            foreach (var user in users.broadcaster)
            {
                if (!UserCoins.ContainsKey(user))
                    UserCoins.Add(user, new TwitchUser { Name = user, Coins = 0 });

                UserCoins[user].Coins += 100;
            }

            foreach (var user in users.admins)
            {
                if (!UserCoins.ContainsKey(user))
                    UserCoins.Add(user, new TwitchUser { Name = user, Coins = 0 });

                UserCoins[user].Coins += 100;
            }

            foreach (var user in users.moderators)
            {
                if (!UserCoins.ContainsKey(user))
                    UserCoins.Add(user, new TwitchUser { Name = user, Coins = 0 });

                UserCoins[user].Coins += 100;
            }

            foreach (var user in users.vips)
            {
                if (!UserCoins.ContainsKey(user))
                    UserCoins.Add(user, new TwitchUser { Name = user, Coins = 0 });

                UserCoins[user].Coins += 100;
            }

            foreach (var user in users.viewers)
            {
                if (!UserCoins.ContainsKey(user))
                    UserCoins.Add(user, new TwitchUser { Name = user, Coins = 0 });

                UserCoins[user].Coins += 100;
            }


            TwitchService.UserCoinsUpdated(this, new ChangeEventArgs());
        }
    }
}