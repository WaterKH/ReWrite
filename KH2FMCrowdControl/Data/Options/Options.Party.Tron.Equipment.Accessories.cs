using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeTronAccessoriesOptions()
        {
            var accessories = new List<ButtonTemplate>
            {
                new ButtonTemplate { Name = Constants.None, Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set to Nothing", ImageUrl = "" },
                new ButtonTemplate { Name = Constants.AbilityRing, Cost = Constants.Cost100, Value = 8, ManipulationType = ManipulationType.Set, Description = "Give Ability Ring", ImageUrl = "Items/Give/Accessories/Ability_Ring.png" },
                new ButtonTemplate { Name = Constants.EngineersRing, Cost = Constants.Cost200, Value = 9, ManipulationType = ManipulationType.Set, Description = "Give Engineer's Ring", ImageUrl = "Items/Give/Accessories/Engineers_Ring.png" },
                new ButtonTemplate { Name = Constants.TechniciansRing, Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Give Technician's Ring", ImageUrl = "Items/Give/Accessories/Technicians_Ring.png" },
                new ButtonTemplate { Name = Constants.ExpertsRing, Cost = Constants.Cost400, Value = 11, ManipulationType = ManipulationType.Set, Description = "Give Expert's Ring", ImageUrl = "Items/Give/Accessories/Experts_Ring.png" },
                new ButtonTemplate { Name = Constants.MastersRing, Cost = Constants.Cost500, Value = 34, ManipulationType = ManipulationType.Set, Description = "Give Master's Ring", ImageUrl = "Items/Give/Accessories/Masters_Ring.png" },
                new ButtonTemplate { Name = Constants.ExecutivesRing, Cost = Constants.Cost750, Value = 599, ManipulationType = ManipulationType.Set, Description = "Give Executive's Ring", ImageUrl = "Items/Give/Accessories/Executives_Ring.png" },
                new ButtonTemplate { Name = Constants.SkillRing, Cost = Constants.Cost300, Value = 38, ManipulationType = ManipulationType.Set, Description = "Give Skill Ring", ImageUrl = "Items/Give/Accessories/Skill_Ring.png" },
                new ButtonTemplate { Name = Constants.SkillfulRing, Cost = Constants.Cost400, Value = 39, ManipulationType = ManipulationType.Set, Description = "Give Skillful Ring", ImageUrl = "Items/Give/Accessories/Skillful_Ring.png" },
                new ButtonTemplate { Name = Constants.CosmicRing, Cost = Constants.Cost500, Value = 52, ManipulationType = ManipulationType.Set, Description = "Give Cosmic Ring", ImageUrl = "Items/Give/Accessories/Cosmic_Ring.png" },
                new ButtonTemplate { Name = Constants.SardonyxRing, Cost = Constants.Cost200, Value = 12, ManipulationType = ManipulationType.Set, Description = "Give Sardonyx Ring", ImageUrl = "Items/Give/Accessories/Sardonyx_Ring.png" },
                new ButtonTemplate { Name = Constants.TourmalineRing, Cost = Constants.Cost300, Value = 13, ManipulationType = ManipulationType.Set, Description = "Give Tourmaline Ring", ImageUrl = "Items/Give/Accessories/Tourmaline_Ring.png" },
                new ButtonTemplate { Name = Constants.AquamarineRing, Cost = Constants.Cost400, Value = 14, ManipulationType = ManipulationType.Set, Description = "Give Aquamarine Ring", ImageUrl = "Items/Give/Accessories/Aquamarine_Ring.png" },
                new ButtonTemplate { Name = Constants.GarnetRing, Cost = Constants.Cost500, Value = 15, ManipulationType = ManipulationType.Set, Description = "Give Garnet Ring", ImageUrl = "Items/Give/Accessories/Garnet_Ring.png" },
                new ButtonTemplate { Name = Constants.DiamondRing, Cost = Constants.Cost750, Value = 16, ManipulationType = ManipulationType.Set, Description = "Give Diamond Ring", ImageUrl = "Items/Give/Accessories/Diamond_Ring.png" },
                new ButtonTemplate { Name = Constants.SilverRing, Cost = Constants.Cost200, Value = 17, ManipulationType = ManipulationType.Set, Description = "Give Silver Ring", ImageUrl = "Items/Give/Accessories/Silver_Ring.png" },
                new ButtonTemplate { Name = Constants.GoldRing, Cost = Constants.Cost300, Value = 18, ManipulationType = ManipulationType.Set, Description = "Give Gold Ring", ImageUrl = "Items/Give/Accessories/Gold_Ring.png" },
                new ButtonTemplate { Name = Constants.PlatinumRing, Cost = Constants.Cost400, Value = 19, ManipulationType = ManipulationType.Set, Description = "Give Platinum Ring", ImageUrl = "Items/Give/Accessories/Platinum_Ring.png" },
                new ButtonTemplate { Name = Constants.MythrilRing, Cost = Constants.Cost500, Value = 20, ManipulationType = ManipulationType.Set, Description = "Give Mythril Ring", ImageUrl = "Items/Give/Accessories/Mythril_Ring.png" },
                new ButtonTemplate { Name = Constants.OrichalcumRing, Cost = Constants.Cost750, Value = 28, ManipulationType = ManipulationType.Set, Description = "Give Orichalcum Ring", ImageUrl = "Items/Give/Accessories/Orichalcum_Ring.png" },
                new ButtonTemplate { Name = Constants.SoldierEarring, Cost = Constants.Cost300, Value = 40, ManipulationType = ManipulationType.Set, Description = "Give Soldier Earring", ImageUrl = "Items/Give/Accessories/Soldier_Earring.png" },
                new ButtonTemplate { Name = Constants.FencerEarring, Cost = Constants.Cost400, Value = 46, ManipulationType = ManipulationType.Set, Description = "Give Fencer Earring", ImageUrl = "Items/Give/Accessories/Fencer_Earring.png" },
                new ButtonTemplate { Name = Constants.MageEarring, Cost = Constants.Cost500, Value = 47, ManipulationType = ManipulationType.Set, Description = "Give Mage Earring", ImageUrl = "Items/Give/Accessories/Mage_Earring.png" },
                new ButtonTemplate { Name = Constants.SlayerEarring, Cost = Constants.Cost750, Value = 48, ManipulationType = ManipulationType.Set, Description = "Give Slayer Earring", ImageUrl = "Items/Give/Accessories/Slayer_Earring.png" },
                new ButtonTemplate { Name = Constants.Medal, Cost = Constants.Cost500, Value = 53, ManipulationType = ManipulationType.Set, Description = "Give Medal", ImageUrl = "Items/Give/Accessories/Medal.png" },
                new ButtonTemplate { Name = Constants.MoonAmulet, Cost = Constants.Cost400, Value = 35, ManipulationType = ManipulationType.Set, Description = "Give Moon Amulet", ImageUrl = "Items/Give/Accessories/Moon_Amulet.png" },
                new ButtonTemplate { Name = Constants.StarCharm, Cost = Constants.Cost500, Value = 36, ManipulationType = ManipulationType.Set, Description = "Give Star Charm", ImageUrl = "Items/Give/Accessories/Star_Charm.png" },
                new ButtonTemplate { Name = Constants.CosmicArts, Cost = Constants.Cost750, Value = 56, ManipulationType = ManipulationType.Set, Description = "Give Cosmic Arts", ImageUrl = "Items/Give/Accessories/Cosmic_Arts.png" },
                new ButtonTemplate { Name = Constants.ShadowArchive, Cost = Constants.Cost500, Value = 57, ManipulationType = ManipulationType.Set, Description = "Give Shadow Archive", ImageUrl = "Items/Give/Accessories/Shadow_Archive.png" },
                new ButtonTemplate { Name = Constants.ShadowArchivePlus, Cost = Constants.Cost750, Value = 58, ManipulationType = ManipulationType.Set, Description = "Give Shadow Archive+", ImageUrl = "Items/Give/Accessories/Shadow_ArchivePlus.png" },
                new ButtonTemplate { Name = Constants.FullBloom, Cost = Constants.Cost500, Value = 64, ManipulationType = ManipulationType.Set, Description = "Give Full Bloom", ImageUrl = "Items/Give/Accessories/Full_Bloom.png" },
                new ButtonTemplate { Name = Constants.FullBloomPlus, Cost = Constants.Cost750, Value = 66, ManipulationType = ManipulationType.Set, Description = "Give Full Bloom+", ImageUrl = "Items/Give/Accessories/Full_BloomPlus.png" },
                new ButtonTemplate { Name = Constants.DrawRing, Cost = Constants.Cost750, Value = 65, ManipulationType = ManipulationType.Set, Description = "Give Draw Ring", ImageUrl = "Items/Give/Accessories/Draw_Ring.png" },
                new ButtonTemplate { Name = Constants.LuckyRing, Cost = Constants.Cost750, Value = 63, ManipulationType = ManipulationType.Set, Description = "Give Lucky Ring", ImageUrl = "Items/Give/Accessories/Lucky_Ring.png" },
            };

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Accessory Slots",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Tron,
                    Cost = 0,
                    Description = "Update Number of Tron's Accessory Slots",
                    ImageUrl = "Shared/Accessories/ACC.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No Slots", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Tron's Accessory Slots to 0", ImageUrl = "", MethodName = "SendTronAccessorySlotsMessage" },
                        new ButtonTemplate { Name = "1 Slot", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Tron's Accessory Slots to 1", ImageUrl = "Shared/Accessories/ACC1.png", MethodName = "SendTronAccessorySlotsMessage" },    
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Accessory Slot 1",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Tron,
                    Cost = 0,
                    Description = "Update Tron's Accessory Slot 1",
                    ImageUrl = "Shared/Accessories/ACC1.png",
                    SubMethodParams = accessories.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Accessory Slot 1")).SubMethodParams.ForEach(x => x.MethodName = "SendTronAccessorySlot1Message");
            
            return options;
        }
    }
}