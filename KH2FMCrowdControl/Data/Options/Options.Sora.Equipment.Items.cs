﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSoraItemsOptions()
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
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Update Sora's Item Slots",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No Slots", Cost = Constants.Cost2000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Item Slots to 0", ImageUrl = "", MethodName = "SendSoraItemSlotsMessage" },
                        new ButtonTemplate { Name = "1 Slot", Cost = Constants.Cost400, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Item Slots to 1", ImageUrl = "Items/Potion.png", MethodName = "SendSoraItemSlotsMessage" },
                        new ButtonTemplate { Name = "2 Slot", Cost = Constants.Cost300, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Sora's Item Slots to 2", ImageUrl = "Items/Potion.png", MethodName = "SendSoraItemSlotsMessage" },
                        new ButtonTemplate { Name = "3 Slot", Cost = Constants.Cost250, Value = 3, ManipulationType = ManipulationType.Set, Description = "Set Sora's Item Slots to 3", ImageUrl = "Items/Potion.png", MethodName = "SendSoraItemSlotsMessage" },
                        new ButtonTemplate { Name = "4 Slot", Cost = Constants.Cost200, Value = 4, ManipulationType = ManipulationType.Set, Description = "Set Sora's Item Slots to 4", ImageUrl = "Items/Potion.png", MethodName = "SendSoraItemSlotsMessage" },
                        new ButtonTemplate { Name = "5 Slot", Cost = Constants.Cost250, Value = 5, ManipulationType = ManipulationType.Set, Description = "Set Sora's Item Slots to 5", ImageUrl = "Items/Potion.png", MethodName = "SendSoraItemSlotsMessage" },
                        new ButtonTemplate { Name = "6 Slot", Cost = Constants.Cost300, Value = 6, ManipulationType = ManipulationType.Set, Description = "Set Sora's Item Slots to 6", ImageUrl = "Items/Potion.png", MethodName = "SendSoraItemSlotsMessage" },
                        new ButtonTemplate { Name = "7 Slot", Cost = Constants.Cost400, Value = 7, ManipulationType = ManipulationType.Set, Description = "Set Sora's Item Slots to 7", ImageUrl = "Items/Potion.png", MethodName = "SendSoraItemSlotsMessage" },
                        new ButtonTemplate { Name = "8 Slot", Cost = Constants.Cost500, Value = 8, ManipulationType = ManipulationType.Set, Description = "Set Sora's Item Slots to 8", ImageUrl = "Items/Potion.png", MethodName = "SendSoraItemSlotsMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 1",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Update Sora's Item Slot 1",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 2",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Update Sora's Item Slot 2",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 3",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Update Sora's Item Slot 3",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 4",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Update Sora's Item Slot 4",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 5",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Update Sora's Item Slot 5",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 6",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Update Sora's Item Slot 6",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 7",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Update Sora's Item Slot 7",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Item Slot 8",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Update Sora's Item Slot 8",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = items.CreateListFromList()
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 1")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraItemSlot1Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 2")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraItemSlot2Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 3")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraItemSlot3Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 4")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraItemSlot4Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 5")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraItemSlot5Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 6")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraItemSlot6Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 7")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraItemSlot7Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Item Slot 8")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraItemSlot8Message");

            return options;
        }
    }
}