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
                    Category = GroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slots",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = "No Slots", Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 0", ImageUrl = "", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGoofyItemSlotsMessage) },
                        new KHButtonTemplate { Name = "1 Slot", Cost = Constants.Cost250, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 1", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGoofyItemSlotsMessage) },
                        new KHButtonTemplate { Name = "2 Slot", Cost = Constants.Cost200, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 2", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGoofyItemSlotsMessage) },
                        new KHButtonTemplate { Name = "3 Slot", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 1", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGoofyItemSlotsMessage) },
                        new KHButtonTemplate { Name = "4 Slot", Cost = Constants.Cost400, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 2", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGoofyItemSlotsMessage) },
                    }
                },
                new KHButtonTemplate
                {
                    Name = "Change Item Slot 1",
                    Category = GroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slot 1",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new KHButtonTemplate
                {
                    Name = "Change Item Slot 2",
                    Category = GroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slot 2",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new KHButtonTemplate
                {
                    Name = "Change Item Slot 3",
                    Category = GroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slot 3",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new KHButtonTemplate
                {
                    Name = "Change Item Slot 4",
                    Category = GroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slot 4",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 1")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGoofyItemSlot1Message));
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 2")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGoofyItemSlot2Message));
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 3")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGoofyItemSlot3Message));
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 4")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendGoofyItemSlot4Message));

            return options;
        }
    }
}