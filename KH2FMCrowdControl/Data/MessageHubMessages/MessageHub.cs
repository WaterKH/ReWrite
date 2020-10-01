﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public class MessageHub : Hub
    {
        public static event MessageHubDelegate OnConnectionStatusChanged;

        public override Task OnConnectedAsync()
        {
            var username = Context.GetHttpContext().Request.Query["username"];

            if (!string.IsNullOrEmpty(username))
            {
                if (!DbContext.Hosts.ContainsKey(username))
                    DbContext.Hosts.Add(username, new Host());

                DbContext.Hosts[username].ConnectionId = Context.ConnectionId;

                SendConnectionStatusChange(this, new MessageHubArgs { ConnectionStatus = "Connected", ConnectionId = Context.ConnectionId });
            }

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            //var username = Context.GetHttpContext().Request.Query["username"];

            //if (!string.IsNullOrEmpty(username))
            //{
            //    if (!DbContext.Hosts.ContainsKey(username))
            //        DbContext.Hosts.Remove(username);
            //}

            //DbContext.Hosts[username].ConnectionId = string.Empty;

            SendConnectionStatusChange(this, new MessageHubArgs { ConnectionStatus = "Disconnected" });

            return base.OnDisconnectedAsync(exception);
        }

        public static void SendConnectionStatusChange(object sender, MessageHubArgs e)
        {
            OnConnectionStatusChanged?.Invoke(sender, e);
        }
    }
}