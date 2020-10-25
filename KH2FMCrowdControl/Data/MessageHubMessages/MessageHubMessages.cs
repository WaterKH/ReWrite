﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {
        private readonly IHubContext<MessageHub> messageHubContext;

        public MessageHubMessages(IHubContext<MessageHub> hubContext)
        {
            this.messageHubContext = hubContext;
        }

        private async Task SendUpdateMemoryMessage(string hostName, MemoryObject message)
        {
            DbContext.Hosts.TryGetValue(hostName, out var host);

            if (host != null)
                await messageHubContext.Clients.Client(host.ConnectionId).SendAsync("SendUpdateMemoryMessage", message);
        }

        private async Task SendUpdateMultipleMemoryMessage(string hostName, MemoryObject[] message)
        {
            DbContext.Hosts.TryGetValue(hostName, out var host);

            if (host != null)
                await messageHubContext.Clients.Client(host.ConnectionId).SendAsync("SendUpdateMultipleMemoryMessage", message);
        }

        private async Task SendUpdateMemoryRangeMessage(string hostName, MemoryObject message, int maxNumber, int toggleValue)
        {
            DbContext.Hosts.TryGetValue(hostName, out var host);

            if (host != null)
                await messageHubContext.Clients.Client(host.ConnectionId).SendAsync("SendUpdateMemoryRangeMessage", message, maxNumber, toggleValue);
        }
    }
}