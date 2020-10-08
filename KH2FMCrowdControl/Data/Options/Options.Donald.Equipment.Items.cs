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
        public async Task<List<KHButtonTemplate>> InitializeDonaldItemsOptions()
        {
            var items = new List<KHButtonTemplate>
            {
                new KHButtonTemplate { Name = Constants.None, Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set to Nothing", ImageUrl = "" },
                new KHButtonTemplate { Name = Constants.Potion, Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Set, Description = "Give Potion", ImageUrl = "Items/Potion.png" },
                new KHButtonTemplate { Name = Constants.HiPotion, Cost = Constants.Cost100, Value = 2, ManipulationType = ManipulationType.Set, Description = "Give Hi-Potion", ImageUrl = "Items/Hi-Potion.png" },
                new KHButtonTemplate { Name = Constants.Ether, Cost = Constants.Cost200, Value = 3, ManipulationType = ManipulationType.Set, Description = "Give Ether", ImageUrl = "Items/Ether.png" },
                new KHButtonTemplate { Name = Constants.Elixir, Cost = Constants.Cost250, Value = 4, ManipulationType = ManipulationType.Set, Description = "Give Elixir", ImageUrl = "Items/Elixir.png" },
                new KHButtonTemplate { Name = Constants.MegaPotion, Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Set, Description = "Give Mega-Potion", ImageUrl = "Items/Mega-Potion.png" },
                new KHButtonTemplate { Name = Constants.MegaEther, Cost = Constants.Cost250, Value = 6, ManipulationType = ManipulationType.Set, Description = "Give Mega-Ether", ImageUrl = "Items/Mega-Ether.png" },
                new KHButtonTemplate { Name = Constants.Megalixir, Cost = Constants.Cost300, Value = 7, ManipulationType = ManipulationType.Set, Description = "Give Megalixir", ImageUrl = "Items/Megalixir.png" },
            };

            var options = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Change Item Slots",
                    Category = GroupType.Donald,
                    Cost = 0,
                    Description = "Update Donald's Item Slots",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = "No Slots", Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 0", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "1 Slot", Cost = Constants.Cost250, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 1", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "2 Slot", Cost = Constants.Cost200, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 2", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                    }
                },
                new KHButtonTemplate
                {
                    Name = "Change Item Slot 1",
                    Category = GroupType.Donald,
                    Cost = 0,
                    Description = "Update Donald's Item Slot 1",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new KHButtonTemplate
                {
                    Name = "Change Item Slot 2",
                    Category = GroupType.Donald,
                    Cost = 0,
                    Description = "Update Donald's Item Slot 2",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 1")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot1Message));
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 2")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot2Message));

            return options;
        }
    }
}