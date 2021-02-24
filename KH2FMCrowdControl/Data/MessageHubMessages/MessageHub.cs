using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public class MessageHub : Hub
    {
        public static event MessageHubDelegate OnConnectionStatusChanged;
        public static event DynamicUIDelegate OnDynamicUIUpdateReceived;

        public override Task OnConnectedAsync()
        {
            var username = Context.GetHttpContext().Request.Query["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                var lowerUsername = username.ToLower();

                if (!DbContext.Hosts.ContainsKey(lowerUsername))
                    DbContext.Hosts.Add(lowerUsername, new Host());

                DbContext.Hosts[lowerUsername].ConnectionId = Context.ConnectionId;

                System.Diagnostics.Trace.WriteLine($"{username} MessageHub Connected...");

                SendConnectionStatusChange(this, new MessageHubArgs { HostName = lowerUsername, ConnectionStatus = "Connected", ConnectionId = Context.ConnectionId });
            }

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            var username = Context.GetHttpContext().Request.Query["username"].ToString();

            if (!string.IsNullOrEmpty(username))
            {
                var lowerUsername = username.ToLower();

                if (DbContext.Hosts.ContainsKey(lowerUsername))
                    DbContext.Hosts.Remove(lowerUsername);

                System.Diagnostics.Trace.WriteLine($"{username} MessageHub Disconnected...");

                //DbContext.Hosts[username].ConnectionId = string.Empty;

                SendConnectionStatusChange(this, new MessageHubArgs { HostName = lowerUsername, ConnectionStatus = "Disconnected" });
            }

            return base.OnDisconnectedAsync(exception);
        }

        public void SendDynamicUIResponseMessage(DynamicUIResponse response)
        {
            SendDynamicUIResponseMessage(this, new DynamicUIArgs { HostName = response.HostName, Options = response.Options });
        }

        public static void SendConnectionStatusChange(object sender, MessageHubArgs e)
        {
            OnConnectionStatusChanged?.Invoke(sender, e);
        }

        public static void SendDynamicUIResponseMessage(object sender, DynamicUIArgs d)
        {
            OnDynamicUIUpdateReceived?.Invoke(sender, d);
        }

        public void SendResponseMessage(Response response)
        {
            // Nothing to do here now - ClientCache is updated, so no need to refund or show error
            Console.WriteLine();
        }

        public void RequestUpdateOptionsMessage(string hostName)
        {
            Task.Run(() => MessageHubMessages.SendUpdateOptionsMessage(hostName));
        }
    }
}