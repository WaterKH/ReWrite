using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSoraQuickMenuOptions()
        {
            var menuItems = new List<ButtonTemplate>
            {
                new ButtonTemplate { Name = Constants.None, Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set to Nothing", ImageUrl = "" },
                new ButtonTemplate { Name = Constants.Fire, Cost = Constants.Cost500, Value = 49, ManipulationType = ManipulationType.Set, Description = "Set slot to Fire Element", ImageUrl = "Sora/Magic/MagicFire1.png" },
                new ButtonTemplate { Name = Constants.Blizzard, Cost = Constants.Cost500, Value = 51, ManipulationType = ManipulationType.Set, Description = "Set slot to Blizzard Element", ImageUrl = "Sora/Magic/MagicIce1.png" },
                new ButtonTemplate { Name = Constants.Thunder, Cost = Constants.Cost500, Value = 50, ManipulationType = ManipulationType.Set, Description = "Set slot to Thunder Element", ImageUrl = "Sora/Magic/MagicThunder1.png" },
                new ButtonTemplate { Name = Constants.Cure, Cost = Constants.Cost500, Value = 52, ManipulationType = ManipulationType.Set, Description = "Set slot to Cure Element", ImageUrl = "Sora/Magic/MagicCure1.png" },
                new ButtonTemplate { Name = Constants.Magnet, Cost = Constants.Cost500, Value = 174, ManipulationType = ManipulationType.Set, Description = "Set slot to Magnet Element", ImageUrl = "Sora/Magic/MagicMagnet1.png" },
                new ButtonTemplate { Name = Constants.Reflect, Cost = Constants.Cost500, Value = 177, ManipulationType = ManipulationType.Set, Description = "Set slot to Reflect Element", ImageUrl = "Sora/Magic/MagicReflect1.png" },
                new ButtonTemplate { Name = Constants.Potion, Cost = Constants.Cost300, Value = 23, ManipulationType = ManipulationType.Set, Description = "Set slot to Potion Item", ImageUrl = "Items/Give/Items/Potion.png" },
                new ButtonTemplate { Name = Constants.HiPotion, Cost = Constants.Cost400, Value = 20, ManipulationType = ManipulationType.Set, Description = "Set slot to Hi-Potion Item", ImageUrl = "Items/Give/Items/Hi-Potion.png" },
                new ButtonTemplate { Name = Constants.Ether, Cost = Constants.Cost500, Value = 21, ManipulationType = ManipulationType.Set, Description = "Set slot to Ether Item", ImageUrl = "Items/Give/Items/Ether.png" },
                new ButtonTemplate { Name = Constants.Elixir, Cost = Constants.Cost400, Value = 22, ManipulationType = ManipulationType.Set, Description = "Set slot to Elixir Item", ImageUrl = "Items/Give/Items/Elixir.png" },
                new ButtonTemplate { Name = Constants.MegaPotion, Cost = Constants.Cost200, Value = 242, ManipulationType = ManipulationType.Set, Description = "Set slot to Mega-Potion Item", ImageUrl = "Items/Give/Items/Mega-Potion.png" },
                new ButtonTemplate { Name = Constants.MegaEther, Cost = Constants.Cost300, Value = 243, ManipulationType = ManipulationType.Set, Description = "Set slot to Mega-Ether Item", ImageUrl = "Items/Give/Items/Mega-Ether.png" },
                new ButtonTemplate { Name = Constants.Megalixir, Cost = Constants.Cost500, Value = 244, ManipulationType = ManipulationType.Set, Description = "Set slot to Megalixir Item", ImageUrl = "Items/Give/Items/Megalixir.png" },
            };

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Quick Menu Slot 1",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.QuickMenu,
                    Cost = 0,
                    Description = "Update Sora's Quick Menu Slot 1",
                    ImageUrl = "Sora/QuickMenu/Shortcut1.png",
                    SubMethodParams = menuItems.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Quick Menu Slot 2",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.QuickMenu,
                    Cost = 0,
                    Description = "Update Sora's Quick Menu Slot 2",
                    ImageUrl = "Sora/QuickMenu/Shortcut2.png",
                    SubMethodParams = menuItems.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Quick Menu Slot 3",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.QuickMenu,
                    Cost = 0,
                    Description = "Update Sora's Quick Menu Slot 3",
                    ImageUrl = "Sora/QuickMenu/Shortcut3.png",
                    SubMethodParams = menuItems.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Quick Menu Slot 4",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.QuickMenu,
                    Cost = 0,
                    Description = "Update Sora's Quick Menu Slot 4",
                    ImageUrl = "Sora/QuickMenu/Shortcut4.png",
                    SubMethodParams = menuItems.CreateListFromList()
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Quick Menu Slot 1")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraQuickMenuSlot1Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Quick Menu Slot 2")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraQuickMenuSlot2Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Quick Menu Slot 3")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraQuickMenuSlot3Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Quick Menu Slot 4")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraQuickMenuSlot4Message");

            return options;
        }
    }
}