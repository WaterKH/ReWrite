using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeDonaldWeaponsOptions()
        {
            var items = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Equip Staff",
                    Category = GroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Staff to have Donald Wield",
                    ImageUrl = "Staffs/Mages_Staff.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Mage's Staff", Cost = 450, Value = 75, ManipulationType = ManipulationType.Set, Description = "Equip Mage's Staff to Donald's Weapon Slot", ImageUrl = "Staffs/Mages_Staff.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Hammer Staff", Cost = 450, Value = 148, ManipulationType = ManipulationType.Set, Description = "Equip Hammer Staff to Donald's Weapon Slot", ImageUrl = "Staffs/Hammer_Staff.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Victory Bell", Cost = 450, Value = 149, ManipulationType = ManipulationType.Set, Description = "Equip Victory Bell to Donald's Weapon Slot", ImageUrl = "Staffs/Victory_Bell.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Comet Staff", Cost = 800, Value = 151, ManipulationType = ManipulationType.Set, Description = "Equip Comet Staff to Donald's Weapon Slot", ImageUrl = "Staffs/Comet_Staff.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Lord's Broom", Cost = 1000, Value = 152, ManipulationType = ManipulationType.Set, Description = "Equip Lord's Broom to Donald's Weapon Slot", ImageUrl = "Staffs/Lords_Broom.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Wisdom Wand", Cost = 1000, Value = 153, ManipulationType = ManipulationType.Set, Description = "Equip Wisdom Wand to Donald's Weapon Slot", ImageUrl = "Staffs/Wisdom_Wand.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Meteor Staff", Cost = 650, Value = 150, ManipulationType = ManipulationType.Set, Description = "Equip Meteor Staff to Donald's Weapon Slot", ImageUrl = "Staffs/Meteor_Staff.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Rising Dragon", Cost = 1000, Value = 154, ManipulationType = ManipulationType.Set, Description = "Equip Rising Dragon to Donald's Weapon Slot", ImageUrl = "Staffs/Rising_Dragon.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Nobody Lance", Cost = 1000, Value = 155, ManipulationType = ManipulationType.Set, Description = "Equip Nobody Lance to Donald's Weapon Slot", ImageUrl = "Staffs/Nobody_Lance.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Shaman's Relic", Cost = 450, Value = 156, ManipulationType = ManipulationType.Set, Description = "Equip Shaman's Relic to Donald's Weapon Slot", ImageUrl = "Staffs/Shamans_Relic.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Shaman's Relic+", Cost = 450, Value = 600, ManipulationType = ManipulationType.Set, Description = "Equip Shaman's Relic+ to Donald's Weapon Slot", ImageUrl = "Staffs/Shamans_RelicPlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Staff of Detection", Cost = 450, Value = 161, ManipulationType = ManipulationType.Set, Description = "Equip Staff of Detection to Donald's Weapon Slot", ImageUrl = "Staffs/Staff_of_Detection.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Save the Queen", Cost = 450, Value = 482, ManipulationType = ManipulationType.Set, Description = "Equip Save the Queen to Donald's Weapon Slot", ImageUrl = "Staffs/Save_the_Queen.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Save the Queen+", Cost = 500, Value = 503, ManipulationType = ManipulationType.Set, Description = "Equip Save the Queen+ to Donald's Weapon Slot", ImageUrl = "Staffs/Save_the_QueenPlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Centurion", Cost = 450, Value = 545, ManipulationType = ManipulationType.Set, Description = "Equip Centurion to Donald's Weapon Slot", ImageUrl = "Staffs/Centurion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Centurion+", Cost = 450, Value = 546, ManipulationType = ManipulationType.Set, Description = "Equip Centurion+ to Donald's Weapon Slot", ImageUrl = "Staffs/CenturionPlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Plain Mushroom", Cost = 550, Value = 547, ManipulationType = ManipulationType.Set, Description = "Equip Plain Mushroom to Donald's Weapon Slot", ImageUrl = "Staffs/Plain_Mushroom.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Plain Mushroom+", Cost = 550, Value = 548, ManipulationType = ManipulationType.Set, Description = "Equip Plain Mushroom+ to Donald's Weapon Slot", ImageUrl = "Staffs/Plain_MushroomPlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Precious Mushroom", Cost = 550, Value = 549, ManipulationType = ManipulationType.Set, Description = "Equip Precious Mushroom to Donald's Weapon Slot", ImageUrl = "Staffs/Precious_Mushroom.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Precious Mushroom+", Cost = 550, Value = 550, ManipulationType = ManipulationType.Set, Description = "Equip Precious Mushroom+ to Donald's Weapon Slot", ImageUrl = "Staffs/Precious_MushroomPlus.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                            new KHButtonTemplate { Name = "Premium Mushroom", Cost = 450, Value = 551, ManipulationType = ManipulationType.Set, Description = "Equip Premium Mushroom to Donald's Weapon Slot", ImageUrl = "Staffs/Premium_Mushroom.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage) },
                        }
                }
            };

            return items;
        }
    }
}