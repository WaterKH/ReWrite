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
        public async Task<List<KHButtonTemplate>> InitializeGoofyWeaponsOptions()
        {
            var shields = new List<KHButtonTemplate>
            {
                new KHButtonTemplate { Name = Constants.KnightsShield, Cost = Constants.Cost2000, Value = 49, ManipulationType = ManipulationType.Set, Description = "Equip Knight's Shield to Goofy's Weapon Slot", ImageUrl = "Shields/Kinghts_Shield.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.AdamantShield, Cost = Constants.Cost200, Value = 139, ManipulationType = ManipulationType.Set, Description = "Equip Adamant Shield to Goofy's Weapon Slot", ImageUrl = "Shields/Adamant_Shield.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.ChainGear, Cost = Constants.Cost250, Value = 140, ManipulationType = ManipulationType.Set, Description = "Equip Chain Gear to Goofy's Weapon Slot", ImageUrl = "Shields/Chain_Gear.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.FallingStar, Cost = Constants.Cost250, Value = 142, ManipulationType = ManipulationType.Set, Description = "Equip Falling Star to Goofy's Weapon Slot", ImageUrl = "Shields/Falling_Star.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.Dreamcloud, Cost = Constants.Cost300, Value = 143, ManipulationType = ManipulationType.Set, Description = "Equip Dreamcloud to Goofy's Weapon Slot", ImageUrl = "Shields/Dreamcloud.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.KnightDefender, Cost = Constants.Cost300, Value = 144, ManipulationType = ManipulationType.Set, Description = "Equip Knight Defender to Goofy's Weapon Slot", ImageUrl = "Shields/Knight_Defender.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.OgreShield, Cost = Constants.Cost400, Value = 141, ManipulationType = ManipulationType.Set, Description = "Equip Ogre Shield to Goofy's Weapon Slot", ImageUrl = "Shields/Ogre_Shield.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.GenjiShield, Cost = Constants.Cost400, Value = 145, ManipulationType = ManipulationType.Set, Description = "Equip Genji Shield to Goofy's Weapon Slot", ImageUrl = "Shields/Genji_Shield.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.NobodyGuard, Cost = Constants.Cost500, Value = 147, ManipulationType = ManipulationType.Set, Description = "Equip Nobody Guard to Goofy's Weapon Slot", ImageUrl = "Shields/Nobody_Guard.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.AkashicRecord, Cost = Constants.Cost500, Value = 146, ManipulationType = ManipulationType.Set, Description = "Equip Akashic Record to Goofy's Weapon Slot", ImageUrl = "Shields/Akashic_Record.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.AkashicRecordPlus, Cost = Constants.Cost500, Value = 601, ManipulationType = ManipulationType.Set, Description = "Equip Akashic Record+ to Goofy's Weapon Slot", ImageUrl = "Shields/Akashic_RecordPlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.SaveTheKing, Cost = Constants.Cost750, Value = 483, ManipulationType = ManipulationType.Set, Description = "Equip Save the King to Goofy's Weapon Slot", ImageUrl = "Shields/Save_the_King.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.SaveTheKingPlus, Cost = Constants.Cost750, Value = 504, ManipulationType = ManipulationType.Set, Description = "Equip Save the King+ to Goofy's Weapon Slot", ImageUrl = "Shields/Save_the_KingPlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.FrozenPride, Cost = Constants.Cost500, Value = 552, ManipulationType = ManipulationType.Set, Description = "Equip Frozen Pride to Goofy's Weapon Slot", ImageUrl = "Shields/Frozen_Pride.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.FrozenPridePlus, Cost = Constants.Cost500, Value = 553, ManipulationType = ManipulationType.Set, Description = "Equip Frozen Pride+ to Goofy's Weapon Slot", ImageUrl = "Shields/Frozen_PridePlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.JoyousMushroom, Cost = Constants.Cost400, Value = 554, ManipulationType = ManipulationType.Set, Description = "Equip Joyous Mushroom to Goofy's Weapon Slot", ImageUrl = "Shields/Joyous_Mushroom.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.JoyousMushroomPlus, Cost = Constants.Cost400, Value = 555, ManipulationType = ManipulationType.Set, Description = "Equip Joyous Mushroom+ to Goofy's Weapon Slot", ImageUrl = "Shields/Joyous_MushroomPlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.MajesticMushroom, Cost = Constants.Cost750, Value = 556, ManipulationType = ManipulationType.Set, Description = "Equip Majestic Mushroom to Goofy's Weapon Slot", ImageUrl = "Shields/Majestic_Mushroom.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.MajesticMushroomPlus, Cost = Constants.Cost750, Value = 557, ManipulationType = ManipulationType.Set, Description = "Equip Majestic Mushroom+ to Goofy's Weapon Slot", ImageUrl = "Shields/Majestic_MushroomPlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.UltimateMushroom, Cost = Constants.Cost1000, Value = 558, ManipulationType = ManipulationType.Set, Description = "Equip Ultimate Mushroom to Goofy's Weapon Slot", ImageUrl = "Shields/Ultimate_Mushroom.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
                new KHButtonTemplate { Name = Constants.DetectionShield, Cost = Constants.Cost750, Value = 50, ManipulationType = ManipulationType.Set, Description = "Equip Detection Shield to Goofy's Weapon Slot", ImageUrl = "Shields/Detection_Shield.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipKeybladeMessage) },
            };

            var options = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Equip Shield",
                    Category = GroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Shield to have Goofy Wield",
                    ImageUrl = "Shields/Knights_Shield.png",
                    SubMethodParams = shields.CreateListFromList()
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Equip Shield")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipShieldMessage));

            return options;
        }
    }
}