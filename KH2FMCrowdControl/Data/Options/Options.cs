using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task SetOptionsVisible(string hostName, List<string> options)
        {
            if (!MemoryService.Options.ContainsKey(hostName))
                return;

            foreach (var option in options)
            {
                var group = option.Split(':')[0];
                var name = option.Split(':')[1];
                var value = bool.Parse(option.Split(':')[2]);

                if (MemoryService.Options[hostName][Enum.Parse<GroupType>(group)].FirstOrDefault(x => x.Name == name) != null)
                {
                    MemoryService.Options[hostName][Enum.Parse<GroupType>(group)].FirstOrDefault(x => x.Name == name).IsActive = value;
                }
                else if (MemoryService.Options[hostName][Enum.Parse<GroupType>(group)].FirstOrDefault(x => x.SubMethodParams.Any(y => y.Name == name)) != null)
                {
                    MemoryService.Options[hostName][Enum.Parse<GroupType>(group)]
                        .FirstOrDefault(x => x.SubMethodParams.Any(y => y.Name == name))
                        .SubMethodParams.FirstOrDefault(x => x.SubMethodParams.Any(y => y.Name == name)).IsActive = value;
                }
            }
        }
    }
}