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
            DbContext.Hosts.TryGetValue(request.HostName.ToLower(), out var host);

            if (host != null)
                await messageHubContext.Clients.Client(host.ConnectionId).SendAsync(methodName, request);
        }

        public static async void SendUpdateOptionsMessage(string hostName)
        {
            DbContext.Hosts.TryGetValue(hostName.ToLower(), out var host);

            if (host != null)
            {
                var options = await MemoryService.OptionsClass.GetOptions(hostName.ToLower());

                await messageHubContext.Clients.Client(host.ConnectionId).SendAsync("SendUpdateOptionsMessage", new Option { Options = options.ToDictionary(x => x.Key.ToString(), y => y.Value) });
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