using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public MessageHubMessages messageHubMessages;

        public Options(IHubContext<MessageHub> context)
        {
            messageHubMessages = new MessageHubMessages(context);
        }

        public async Task<Dictionary<GroupType, List<ButtonTemplate>>> InitializeOptions()
        {
            var options = new Dictionary<GroupType, List<ButtonTemplate>>
            {
                { GroupType.Items, await this.InitializeItemOptions() },
                { GroupType.Sora, await this.InitializeSoraOptions() },
                { GroupType.ModelSwap, await this.InitializeModelSwapOptions() },
                { GroupType.Environment, await this.InitializeEnvironmentOptions() },
                { GroupType.Party, await this.InitializePartyOptions() },
                { GroupType.Enemy, await this.InitializeEnemyOptions() },
            };

            return options;
        }

        public async Task<Dictionary<GroupType, List<ButtonTemplate>>> GetOptions(string hostName)
        {
            if (MemoryService.Options.ContainsKey(hostName))
                return MemoryService.Options[hostName];

            return await this.InitializeOptions();
        }
    }
}