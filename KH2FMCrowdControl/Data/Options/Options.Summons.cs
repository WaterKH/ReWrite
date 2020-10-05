using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSummonOptions()
        {
            var options = new List<KHButtonTemplate>() {

                new KHButtonTemplate
                {
                    Name = "Give/ Take Summons",
                    Category = GroupType.Summon,
                    Cost = 0,
                    Description = "Give or Take Sora's Summons",
                    ImageUrl = "Summons/Ukulele_Charm.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = Constants.Give(Constants.UkuleleCharm), Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Ukulele Charm to Sora", ImageUrl = "Summons/Ukulele_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendUkuleleBaseballMessage) },
                        new KHButtonTemplate { Name = Constants.Take(Constants.UkuleleCharm), Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Ukulele Charm from Sora", ImageUrl = "Summons/Ukulele_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendUkuleleBaseballMessage) },
                        new KHButtonTemplate { Name = Constants.Give(Constants.BaseballCharm), Cost = Constants.Cost750, Value = 8, ManipulationType = ManipulationType.Add, Description = "Give Baseball Charm to Sora", ImageUrl = "Summons/Baseball_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendUkuleleBaseballMessage) },
                        new KHButtonTemplate { Name = Constants.Take(Constants.BaseballCharm), Cost = Constants.Cost750, Value = 8, ManipulationType = ManipulationType.Subtract, Description = "Take Baseball Charm from Sora", ImageUrl = "Summons/Baseball_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendUkuleleBaseballMessage) },
                        new KHButtonTemplate { Name = Constants.Give(Constants.LampCharm), Cost = Constants.Cost750, Value = 16, ManipulationType = ManipulationType.Add, Description = "Give Lamp Charm to Sora", ImageUrl = "Summons/Lamp_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendLampFeatherMessage) },
                        new KHButtonTemplate { Name = Constants.Take(Constants.LampCharm), Cost = Constants.Cost750, Value = 16, ManipulationType = ManipulationType.Subtract, Description = "Take Lamp Charm from Sora", ImageUrl = "Summons/Lamp_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendLampFeatherMessage) },
                        new KHButtonTemplate { Name = Constants.Give(Constants.FeatherCharm), Cost = Constants.Cost750, Value = 32, ManipulationType = ManipulationType.Add, Description = "Give Feather Charm to Sora", ImageUrl = "Summons/Feather_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendLampFeatherMessage) },
                        new KHButtonTemplate { Name = Constants.Take(Constants.FeatherCharm), Cost = Constants.Cost750, Value = 32, ManipulationType = ManipulationType.Subtract, Description = "Take Feather Charm from Sora", ImageUrl = "Summons/Feather_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendLampFeatherMessage) },
                    }
                },
                new KHButtonTemplate
                {
                    Name = "Change Summon Timer",
                    Category = GroupType.Summon,
                    Cost = 0,
                    Description = "Give or Take from Sora's Summon Timer",
                    ImageUrl = "Summons/Ukulele_Charm.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = "Set Summon Timer 0", Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Sets Summon Timer to 0", ImageUrl = "Summons/Ukulele_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveTimeMessage) },
                        new KHButtonTemplate { Name = "Set Summon Timer Max", Cost = Constants.Cost500, Value = 5000, ManipulationType = ManipulationType.Set, Description = "Sets Summon Timer to Current Max", ImageUrl = "Summons/Ukulele_Charm.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveTimeMessage) },
                    }
                }
            };

            return options;
        }
    }
}