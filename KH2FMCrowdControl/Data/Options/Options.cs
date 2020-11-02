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
                { GroupType.Drive, await this.InitializeDriveOptions() },
                { GroupType.Summon, await this.InitializeSummonOptions() },
                { GroupType.Sora, await this.InitializeSoraOptions() },
                { GroupType.Donald, await this.InitializeDonaldOptions() },
                { GroupType.Goofy, await this.InitializeGoofyOptions() },
                { GroupType.ModelSwap, await this.InitializeModelSwapOptions() },
                { GroupType.Misc, await this.InitializeMiscOptions() },
                //{ GroupType.Party, await this.InitializePartyOptions() },
            };

            return options;
        }
    }
}