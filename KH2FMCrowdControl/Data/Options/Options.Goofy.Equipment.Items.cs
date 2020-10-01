using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeGoofyItemsOptions()
        {
            var items = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Change Item Slot 1",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Item Slot 1",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "None", Cost = 10, Value = 0, ManipulationType = ManipulationType.Set, Description = "Give Elven Bandana", ImageUrl = "Armor/Elven_Bandana.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElvenBandannaMessage) },
                            new KHButtonTemplate { Name = "Potion", Cost = 10, Value = 1, ManipulationType = ManipulationType.Set, Description = "Give Elven Bandana", ImageUrl = "Armor/Elven_Bandana.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElvenBandannaMessage) },
                            new KHButtonTemplate { Name = "Hi-Potion", Cost = 10, Value = 2, ManipulationType = ManipulationType.Set, Description = "Give Divine Bandana", ImageUrl = "Armor/Divine_Bandana.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDivineBandannaMessage) },
                            new KHButtonTemplate { Name = "Ether", Cost = 10, Value = 3, ManipulationType = ManipulationType.Set, Description = "Give Power Band", ImageUrl = "Armor/Power_Band.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPowerBandMessage) },
                            new KHButtonTemplate { Name = "Elixir", Cost = 10, Value = 4, ManipulationType = ManipulationType.Set, Description = "Give Buster Band", ImageUrl = "Armor/Buster_Band.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendBusterBandMessage) },
                            new KHButtonTemplate { Name = "Mega-Potion", Cost = 10, Value = 5, ManipulationType = ManipulationType.Set, Description = "Give Champion Belt", ImageUrl = "Armor/Champion_Belt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendChampionBeltMessage) },
                            new KHButtonTemplate { Name = "Mega-Ether", Cost = 10, Value = 6, ManipulationType = ManipulationType.Set, Description = "Give Protect Belt", ImageUrl = "Armor/Protect_Belt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendProtectBeltMessage) },
                            new KHButtonTemplate { Name = "Megalixir", Cost = 10, Value = 7, ManipulationType = ManipulationType.Set, Description = "Give Gaia Belt", ImageUrl = "Armor/Gaia_Belt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGaiaBeltMessage) },
                        }
                },
            };

            return items;
        }
    }
}