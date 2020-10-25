using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public MessageHubMessages messageHubMessages;

        public Options(IHubContext<MessageHub> context)
        {
            messageHubMessages = new MessageHubMessages(context);
        }

        public async Task<Dictionary<GroupType, List<KHButtonTemplate>>> InitializeOptions()
        {
            var options = new Dictionary<GroupType, List<KHButtonTemplate>>
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