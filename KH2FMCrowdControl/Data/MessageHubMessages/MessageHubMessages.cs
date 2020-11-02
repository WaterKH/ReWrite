using Microsoft.AspNetCore.SignalR;
using System.Linq;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {
        private static IHubContext<MessageHub> messageHubContext;

        public MessageHubMessages(IHubContext<MessageHub> hubContext)
        {
            messageHubContext = hubContext;
        }

        public static async void SendUpdateMemoryMessage(string methodName, Request request)
        {
            DbContext.Hosts.TryGetValue(request.HostName, out var host);

            if (host != null)
                await messageHubContext.Clients.Client(host.ConnectionId).SendAsync(methodName, request);
        }

        public static async void SendUpdateOptionsMessage(string hostName)
        {
            DbContext.Hosts.TryGetValue(hostName, out var host);

            if (host != null && MemoryService.Options != null)
            {
                MemoryService.Options.TryGetValue(hostName, out var options);

                if (options != null)
                {
                    var altOptions = options.ToDictionary(x => x.Key.ToString(), y => y.Value);

                    await messageHubContext.Clients.Client(host.ConnectionId).SendAsync("SendUpdateOptionsMessage", new Option { Options = altOptions });
                }
            }
        }

        //private async Task SendUpdateMemoryRangeMessage(string methodName, MemoryObject message, int maxNumber, int toggleValue)
        //{
        //    DbContext.Hosts.TryGetValue(hostName, out var host);

        //    if (host != null)
        //        await messageHubContext.Clients.Client(host.ConnectionId).SendAsync("UpdateMemoryRangeMessage", message, maxNumber, toggleValue);
        //}
    }
}