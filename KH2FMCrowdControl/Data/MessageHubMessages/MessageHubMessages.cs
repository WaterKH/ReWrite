using Microsoft.AspNetCore.SignalR;
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
    }
}