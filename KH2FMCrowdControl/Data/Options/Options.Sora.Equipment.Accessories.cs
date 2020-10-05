﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSoraAccessoriesOptions()
        {
            var accessories = new List<KHButtonTemplate>
            {
                new KHButtonTemplate { Name = Constants.None, Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set to Nothing", ImageUrl = "" },
                new KHButtonTemplate { Name = Constants.AbilityRing, Cost = Constants.Cost100, Value = 8, ManipulationType = ManipulationType.Set, Description = "Give Ability Ring", ImageUrl = "Accessories/Ability_Ring.png" },
                new KHButtonTemplate { Name = Constants.EngineersRing, Cost = Constants.Cost200, Value = 9, ManipulationType = ManipulationType.Set, Description = "Give Engineer's Ring", ImageUrl = "Accessories/Engineers_Ring.png" },
                new KHButtonTemplate { Name = Constants.TechniciansRing, Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Give Technician's Ring", ImageUrl = "Accessories/Technicians_Ring.png" },
                new KHButtonTemplate { Name = Constants.ExpertsRing, Cost = Constants.Cost400, Value = 11, ManipulationType = ManipulationType.Set, Description = "Give Expert's Ring", ImageUrl = "Accessories/Experts_Ring.png" },
                new KHButtonTemplate { Name = Constants.MastersRing, Cost = Constants.Cost500, Value = 34, ManipulationType = ManipulationType.Set, Description = "Give Master's Ring", ImageUrl = "Accessories/Masters_Ring.png" },
                new KHButtonTemplate { Name = Constants.ExecutivesRing, Cost = Constants.Cost750, Value = 599, ManipulationType = ManipulationType.Set, Description = "Give Executive's Ring", ImageUrl = "Accessories/Executives_Ring.png" },
                new KHButtonTemplate { Name = Constants.SkillRing, Cost = Constants.Cost300, Value = 38, ManipulationType = ManipulationType.Set, Description = "Give Skill Ring", ImageUrl = "Accessories/Skill_Ring.png" },
                new KHButtonTemplate { Name = Constants.SkillfulRing, Cost = Constants.Cost400, Value = 39, ManipulationType = ManipulationType.Set, Description = "Give Skillful Ring", ImageUrl = "Accessories/Skillful_Ring.png" },
                new KHButtonTemplate { Name = Constants.CosmicRing, Cost = Constants.Cost500, Value = 52, ManipulationType = ManipulationType.Set, Description = "Give Cosmic Ring", ImageUrl = "Accessories/Cosmic_Ring.png" },
                new KHButtonTemplate { Name = Constants.SardonyxRing, Cost = Constants.Cost200, Value = 12, ManipulationType = ManipulationType.Set, Description = "Give Sardonyx Ring", ImageUrl = "Accessories/Sardonyx_Ring.png" },
                new KHButtonTemplate { Name = Constants.TourmalineRing, Cost = Constants.Cost300, Value = 13, ManipulationType = ManipulationType.Set, Description = "Give Tourmaline Ring", ImageUrl = "Accessories/Tourmaline_Ring.png" },
                new KHButtonTemplate { Name = Constants.AquamarineRing, Cost = Constants.Cost400, Value = 14, ManipulationType = ManipulationType.Set, Description = "Give Aquamarine Ring", ImageUrl = "Accessories/Aquamarine_Ring.png" },
                new KHButtonTemplate { Name = Constants.GarnetRing, Cost = Constants.Cost500, Value = 15, ManipulationType = ManipulationType.Set, Description = "Give Garnet Ring", ImageUrl = "Accessories/Garnet_Ring.png" },
                new KHButtonTemplate { Name = Constants.DiamondRing, Cost = Constants.Cost750, Value = 16, ManipulationType = ManipulationType.Set, Description = "Give Diamond Ring", ImageUrl = "Accessories/Diamond_Ring.png" },
                new KHButtonTemplate { Name = Constants.SilverRing, Cost = Constants.Cost200, Value = 17, ManipulationType = ManipulationType.Set, Description = "Give Silver Ring", ImageUrl = "Accessories/Silver_Ring.png" },
                new KHButtonTemplate { Name = Constants.GoldRing, Cost = Constants.Cost300, Value = 18, ManipulationType = ManipulationType.Set, Description = "Give Gold Ring", ImageUrl = "Accessories/Gold_Ring.png" },
                new KHButtonTemplate { Name = Constants.PlatinumRing, Cost = Constants.Cost400, Value = 19, ManipulationType = ManipulationType.Set, Description = "Give Platinum Ring", ImageUrl = "Accessories/Platinum_Ring.png" },
                new KHButtonTemplate { Name = Constants.MythrilRing, Cost = Constants.Cost500, Value = 20, ManipulationType = ManipulationType.Set, Description = "Give Mythril Ring", ImageUrl = "Accessories/Mythril_Ring.png" },
                new KHButtonTemplate { Name = Constants.OrichalcumRing, Cost = Constants.Cost750, Value = 28, ManipulationType = ManipulationType.Set, Description = "Give Orichalcum Ring", ImageUrl = "Accessories/Orichalcum_Ring.png" },
                new KHButtonTemplate { Name = Constants.SoldierEarring, Cost = Constants.Cost300, Value = 40, ManipulationType = ManipulationType.Set, Description = "Give Soldier Earring", ImageUrl = "Accessories/Soldier_Earring.png" },
                new KHButtonTemplate { Name = Constants.FencerEarring, Cost = Constants.Cost400, Value = 46, ManipulationType = ManipulationType.Set, Description = "Give Fencer Earring", ImageUrl = "Accessories/Fencer_Earring.png" },
                new KHButtonTemplate { Name = Constants.MageEarring, Cost = Constants.Cost500, Value = 47, ManipulationType = ManipulationType.Set, Description = "Give Mage Earring", ImageUrl = "Accessories/Mage_Earring.png" },
                new KHButtonTemplate { Name = Constants.SlayerEarring, Cost = Constants.Cost750, Value = 48, ManipulationType = ManipulationType.Set, Description = "Give Slayer Earring", ImageUrl = "Accessories/Slayer_Earring.png" },
                new KHButtonTemplate { Name = Constants.MoonAmulet, Cost = Constants.Cost400, Value = 35, ManipulationType = ManipulationType.Set, Description = "Give Moon Amulet", ImageUrl = "Accessories/Moon_Amulet.png" },
                new KHButtonTemplate { Name = Constants.StarCharm, Cost = Constants.Cost500, Value = 36, ManipulationType = ManipulationType.Set, Description = "Give Star Charm", ImageUrl = "Accessories/Star_Charm.png" },
                new KHButtonTemplate { Name = Constants.CosmicArts, Cost = Constants.Cost750, Value = 56, ManipulationType = ManipulationType.Set, Description = "Give Cosmic Arts", ImageUrl = "Accessories/Cosmic_Arts.png" },
                new KHButtonTemplate { Name = Constants.ShadowArchive, Cost = Constants.Cost500, Value = 57, ManipulationType = ManipulationType.Set, Description = "Give Shadow Archive", ImageUrl = "Accessories/Shadow_Archive.png" },
                new KHButtonTemplate { Name = Constants.ShadowArchivePlus, Cost = Constants.Cost750, Value = 58, ManipulationType = ManipulationType.Set, Description = "Give Shadow Archive+", ImageUrl = "Accessories/Shadow_ArchivePlus.png" },
                new KHButtonTemplate { Name = Constants.FullBloom, Cost = Constants.Cost500, Value = 64, ManipulationType = ManipulationType.Set, Description = "Give Full Bloom", ImageUrl = "Accessories/Full_Bloom.png" },
                new KHButtonTemplate { Name = Constants.FullBloomPlus, Cost = Constants.Cost750, Value = 66, ManipulationType = ManipulationType.Set, Description = "Give Full Bloom+", ImageUrl = "Accessories/Full_BloomPlus.png" },
                new KHButtonTemplate { Name = Constants.Medal, Cost = Constants.Cost500, Value = 53, ManipulationType = ManipulationType.Set, Description = "Give Medal", ImageUrl = "Accessories/Medal.png" },
                new KHButtonTemplate { Name = Constants.DrawRing, Cost = Constants.Cost750, Value = 65, ManipulationType = ManipulationType.Set, Description = "Give Draw Ring", ImageUrl = "Accessories/Draw_Ring.png" },
                new KHButtonTemplate { Name = Constants.LuckyRing, Cost = Constants.Cost750, Value = 63, ManipulationType = ManipulationType.Set, Description = "Give Lucky Ring", ImageUrl = "Accessories/Lucky_Ring.png" },
            };

            var options = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Change Accessory Slots",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Number of Sora's Accessory Slots",
                    ImageUrl = "Accessories/Cosmic_Ring.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = "No Slots", Cost = Constants.Cost2000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Armor Slots to 0", ImageUrl = "", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAccessorySlotsMessage) },
                        new KHButtonTemplate { Name = "1 Slot", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Armor Slots to 1", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAccessorySlotsMessage) },
                        new KHButtonTemplate { Name = "2 Slot", Cost = Constants.Cost250, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Sora's Armor Slots to 2", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAccessorySlotsMessage) },
                        new KHButtonTemplate { Name = "3 Slot", Cost = Constants.Cost300, Value = 3, ManipulationType = ManipulationType.Set, Description = "Set Sora's Armor Slots to 3", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAccessorySlotsMessage) },
                        new KHButtonTemplate { Name = "4 Slot", Cost = Constants.Cost400, Value = 4, ManipulationType = ManipulationType.Set, Description = "Set Sora's Armor Slots to 4", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAccessorySlotsMessage) },
                    }
                },
                new KHButtonTemplate
                {
                    Name = "Change Accessory Slot 1",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Accessory Slot 1",
                    ImageUrl = "Accessories/Cosmic_Ring.png",
                    SubMethodParams = accessories.CreateListFromList()
                },
                new KHButtonTemplate
                {
                    Name = "Change Accessory Slot 2",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Accessory Slot 2",
                    ImageUrl = "Accessories/Cosmic_Ring.png",
                    SubMethodParams = accessories.CreateListFromList()
                },
                new KHButtonTemplate
                {
                    Name = "Change Accessory Slot 3",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Accessory Slot 3",
                    ImageUrl = "Accessories/Cosmic_Ring.png",
                    SubMethodParams = accessories.CreateListFromList()
                },
                new KHButtonTemplate
                {
                    Name = "Change Accessory Slot 4",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Accessory Slot 4",
                    ImageUrl = "Accessories/Cosmic_Ring.png",
                    SubMethodParams = accessories.CreateListFromList()
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Accessory Slot 1")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAccessorySlot1Message));
            options.FirstOrDefault(x => x.Name.Equals("Change Accessory Slot 2")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAccessorySlot2Message));
            options.FirstOrDefault(x => x.Name.Equals("Change Accessory Slot 3")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAccessorySlot3Message));
            options.FirstOrDefault(x => x.Name.Equals("Change Accessory Slot 4")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAccessorySlot4Message));

            return options;
        }
    }
}