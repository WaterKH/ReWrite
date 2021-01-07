﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeCaptainJackSparrowItemsOptions()
        {
            var items = new List<ButtonTemplate>
            {
                new ButtonTemplate { Name = Constants.None, Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set to Nothing", ImageUrl = "" },
                new ButtonTemplate { Name = Constants.Potion, Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Set, Description = "Give Potion", ImageUrl = "Items/Give/Items/Potion.png" },
                new ButtonTemplate { Name = Constants.HiPotion, Cost = Constants.Cost100, Value = 2, ManipulationType = ManipulationType.Set, Description = "Give Hi-Potion", ImageUrl = "Items/Give/Items/Hi-Potion.png" },
                new ButtonTemplate { Name = Constants.Ether, Cost = Constants.Cost200, Value = 3, ManipulationType = ManipulationType.Set, Description = "Give Ether", ImageUrl = "Items/Give/Items/Ether.png" },
                new ButtonTemplate { Name = Constants.Elixir, Cost = Constants.Cost250, Value = 4, ManipulationType = ManipulationType.Set, Description = "Give Elixir", ImageUrl = "Items/Give/Items/Elixir.png" },
                new ButtonTemplate { Name = Constants.MegaPotion, Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Set, Description = "Give Mega-Potion", ImageUrl = "Items/Give/Items/Mega-Potion.png" },
                new ButtonTemplate { Name = Constants.MegaEther, Cost = Constants.Cost250, Value = 6, ManipulationType = ManipulationType.Set, Description = "Give Mega-Ether", ImageUrl = "Items/Give/Items/Mega-Ether.png" },
                new ButtonTemplate { Name = Constants.Megalixir, Cost = Constants.Cost300, Value = 7, ManipulationType = ManipulationType.Set, Description = "Give Megalixir", ImageUrl = "Items/Give/Items/Megalixir.png" },
            };

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Item Slots",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.CaptainJackSparrow,
                    Cost = 0,
                    Description = "Update Captain Jack Sparrow's Item Slots",
                    ImageUrl = "Shared/Items/Item.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No Slots", Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set CaptainJackSparrow's Item Slots to 0", ImageUrl = "", MethodName = "SendCaptainJackSparrowItemSlotsMessage" },
                        new ButtonTemplate { Name = "1 Slot", Cost = Constants.Cost250, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set CaptainJackSparrow's Item Slots to 1", ImageUrl = "Shared/Items/Item1.png", MethodName = "SendCaptainJackSparrowItemSlotsMessage"  },
                        new ButtonTemplate { Name = "2 Slots", Cost = Constants.Cost200, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set CaptainJackSparrow's Item Slots to 2", ImageUrl = "Shared/Items/Item2.png", MethodName = "SendCaptainJackSparrowItemSlotsMessage"  },
                        new ButtonTemplate { Name = "3 Slots", Cost = Constants.Cost200, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set CaptainJackSparrow's Item Slots to 3", ImageUrl = "Shared/Items/Item3.png", MethodName = "SendCaptainJackSparrowItemSlotsMessage"  },
                        new ButtonTemplate { Name = "4 Slots", Cost = Constants.Cost200, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set CaptainJackSparrow's Item Slots to 4", ImageUrl = "Shared/Items/Item4.png", MethodName = "SendCaptainJackSparrowItemSlotsMessage"  },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 1",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.CaptainJackSparrow,
                    Cost = 0,
                    Description = "Update Captain Jack Sparrow's Item Slot 1",
                    ImageUrl = "Shared/Items/Item1.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 2",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.CaptainJackSparrow,
                    Cost = 0,
                    Description = "Update Captain Jack Sparrow's Item Slot 2",
                    ImageUrl = "Shared/Items/Item2.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 3",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.CaptainJackSparrow,
                    Cost = 0,
                    Description = "Update Captain Jack Sparrow's Item Slot 3",
                    ImageUrl = "Shared/Items/Item3.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 4",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.CaptainJackSparrow,
                    Cost = 0,
                    Description = "Update Captain Jack Sparrow's Item Slot 4",
                    ImageUrl = "Shared/Items/Item4.png",
                    SubMethodParams = items.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 1")).SubMethodParams.ForEach(x => x.MethodName = "SendCaptainJackSparrowItemSlot1Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 2")).SubMethodParams.ForEach(x => x.MethodName = "SendCaptainJackSparrowItemSlot2Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 3")).SubMethodParams.ForEach(x => x.MethodName = "SendCaptainJackSparrowItemSlot3Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 4")).SubMethodParams.ForEach(x => x.MethodName = "SendCaptainJackSparrowItemSlot4Message");

            return options;
        }
    }
}