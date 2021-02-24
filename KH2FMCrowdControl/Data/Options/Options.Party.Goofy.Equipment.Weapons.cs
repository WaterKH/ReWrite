using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeGoofyWeaponsOptions()
        {
            var shields = new List<ButtonTemplate>
            {
                new ButtonTemplate { Name = Constants.KnightsShield, Cost = Constants.Cost200, Value = 49, ManipulationType = ManipulationType.Set, Description = "Equip Knight's Shield to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Kinghts_Shield.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.AdamantShield, Cost = Constants.Cost250, Value = 139, ManipulationType = ManipulationType.Set, Description = "Equip Adamant Shield to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Adamant_Shield.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.ChainGear, Cost = Constants.Cost250, Value = 140, ManipulationType = ManipulationType.Set, Description = "Equip Chain Gear to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Chain_Gear.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.FallingStar, Cost = Constants.Cost250, Value = 142, ManipulationType = ManipulationType.Set, Description = "Equip Falling Star to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Falling_Star.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.Dreamcloud, Cost = Constants.Cost300, Value = 143, ManipulationType = ManipulationType.Set, Description = "Equip Dreamcloud to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Dreamcloud.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.KnightDefender, Cost = Constants.Cost300, Value = 144, ManipulationType = ManipulationType.Set, Description = "Equip Knight Defender to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Knight_Defender.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.OgreShield, Cost = Constants.Cost400, Value = 141, ManipulationType = ManipulationType.Set, Description = "Equip Ogre Shield to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Ogre_Shield.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.GenjiShield, Cost = Constants.Cost400, Value = 145, ManipulationType = ManipulationType.Set, Description = "Equip Genji Shield to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Genji_Shield.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.NobodyGuard, Cost = Constants.Cost500, Value = 147, ManipulationType = ManipulationType.Set, Description = "Equip Nobody Guard to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Nobody_Guard.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.AkashicRecord, Cost = Constants.Cost500, Value = 146, ManipulationType = ManipulationType.Set, Description = "Equip Akashic Record to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Akashic_Record.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.AkashicRecordPlus, Cost = Constants.Cost500, Value = 601, ManipulationType = ManipulationType.Set, Description = "Equip Akashic Record+ to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Akashic_RecordPlus.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.SaveTheKing, Cost = Constants.Cost750, Value = 483, ManipulationType = ManipulationType.Set, Description = "Equip Save the King to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Save_the_King.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.SaveTheKingPlus, Cost = Constants.Cost750, Value = 504, ManipulationType = ManipulationType.Set, Description = "Equip Save the King+ to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Save_the_KingPlus.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.FrozenPride, Cost = Constants.Cost500, Value = 552, ManipulationType = ManipulationType.Set, Description = "Equip Frozen Pride to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Frozen_Pride.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.FrozenPridePlus, Cost = Constants.Cost500, Value = 553, ManipulationType = ManipulationType.Set, Description = "Equip Frozen Pride+ to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Frozen_PridePlus.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.JoyousMushroom, Cost = Constants.Cost400, Value = 554, ManipulationType = ManipulationType.Set, Description = "Equip Joyous Mushroom to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Joyous_Mushroom.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.JoyousMushroomPlus, Cost = Constants.Cost400, Value = 555, ManipulationType = ManipulationType.Set, Description = "Equip Joyous Mushroom+ to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Joyous_MushroomPlus.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.MajesticMushroom, Cost = Constants.Cost750, Value = 556, ManipulationType = ManipulationType.Set, Description = "Equip Majestic Mushroom to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Majestic_Mushroom.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.MajesticMushroomPlus, Cost = Constants.Cost750, Value = 557, ManipulationType = ManipulationType.Set, Description = "Equip Majestic Mushroom+ to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Majestic_MushroomPlus.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.UltimateMushroom, Cost = Constants.Cost1000, Value = 558, ManipulationType = ManipulationType.Set, Description = "Equip Ultimate Mushroom to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Ultimate_Mushroom.png", MethodName = "SendEquipKeybladeMessage" },
                new ButtonTemplate { Name = Constants.DetectionShield, Cost = Constants.Cost750, Value = 50, ManipulationType = ManipulationType.Set, Description = "Equip Detection Shield to Goofy's Weapon Slot", ImageUrl = "Items/Give/Shields/Kinghts_Shield.png", MethodName = "SendEquipKeybladeMessage" },
            };

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Equip Shield",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Goofy,
                    Tag = FeatureTagType.Unstable,
                    Cost = 0,
                    Description = "Choose which Shield to have Goofy Wield",
                    ImageUrl = "Shared/SetShieldGoofy.png",
                    SubMethodParams = shields.CreateListFromList()
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Equip Shield")).SubMethodParams.ForEach(x => x.MethodName = "SendEquipShieldMessage");

            return options;
        }
    }
}