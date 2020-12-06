using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeGoofyItemsOptions()
        {
            var items = new List<ButtonTemplate>
            {
                new ButtonTemplate { Name = Constants.None, Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set to Nothing", ImageUrl = "" },
                new ButtonTemplate { Name = Constants.Potion, Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Set, Description = "Give Potion", ImageUrl = "Items/Potion.png" },
                new ButtonTemplate { Name = Constants.HiPotion, Cost = Constants.Cost100, Value = 2, ManipulationType = ManipulationType.Set, Description = "Give Hi-Potion", ImageUrl = "Items/Hi-Potion.png" },
                new ButtonTemplate { Name = Constants.Ether, Cost = Constants.Cost200, Value = 3, ManipulationType = ManipulationType.Set, Description = "Give Ether", ImageUrl = "Items/Ether.png" },
                new ButtonTemplate { Name = Constants.Elixir, Cost = Constants.Cost250, Value = 4, ManipulationType = ManipulationType.Set, Description = "Give Elixir", ImageUrl = "Items/Elixir.png" },
                new ButtonTemplate { Name = Constants.MegaPotion, Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Set, Description = "Give Mega-Potion", ImageUrl = "Items/Mega-Potion.png" },
                new ButtonTemplate { Name = Constants.MegaEther, Cost = Constants.Cost250, Value = 6, ManipulationType = ManipulationType.Set, Description = "Give Mega-Ether", ImageUrl = "Items/Mega-Ether.png" },
                new ButtonTemplate { Name = Constants.Megalixir, Cost = Constants.Cost300, Value = 7, ManipulationType = ManipulationType.Set, Description = "Give Megalixir", ImageUrl = "Items/Megalixir.png" },
            };

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Item Slots",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slots",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No Slots", Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 0", ImageUrl = "", MethodName = "SendGoofyItemSlotsMessage" },
                        new ButtonTemplate { Name = "1 Slot", Cost = Constants.Cost250, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 1", ImageUrl = "Items/Potion.png", MethodName = "SendGoofyItemSlotsMessage" },
                        new ButtonTemplate { Name = "2 Slots", Cost = Constants.Cost200, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 2", ImageUrl = "Items/Potion.png", MethodName = "SendGoofyItemSlotsMessage" },
                        new ButtonTemplate { Name = "3 Slots", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 1", ImageUrl = "Items/Potion.png", MethodName = "SendGoofyItemSlotsMessage" },
                        new ButtonTemplate { Name = "4 Slots", Cost = Constants.Cost400, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Item Slots to 2", ImageUrl = "Items/Potion.png", MethodName = "SendGoofyItemSlotsMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 1",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slot 1",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 2",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slot 2",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 3",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slot 3",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 4",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Update Goofy's Item Slot 4",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 1")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyItemSlot1Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 2")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyItemSlot2Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 3")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyItemSlot3Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 4")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyItemSlot4Message");

            return options;
        }
    }
}