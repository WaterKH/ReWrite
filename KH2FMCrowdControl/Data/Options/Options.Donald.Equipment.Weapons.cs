using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeDonaldWeaponsOptions()
        {
            var staffs = new List<KHButtonTemplate>
            {   
                new KHButtonTemplate { Name = Constants.None, Cost = Constants.Cost2000, Value = 75, ManipulationType = ManipulationType.Set, Description = "Equip Mage's Staff to Donald's Weapon Slot", ImageUrl = "" },
                new KHButtonTemplate { Name = Constants.MagesStaff, Cost = Constants.Cost200, Value = 75, ManipulationType = ManipulationType.Set, Description = "Equip Mage's Staff to Donald's Weapon Slot", ImageUrl = "Staffs/Mages_Staff.png" },
                new KHButtonTemplate { Name = Constants.HammerStaff, Cost = Constants.Cost250, Value = 148, ManipulationType = ManipulationType.Set, Description = "Equip Hammer Staff to Donald's Weapon Slot", ImageUrl = "Staffs/Hammer_Staff.png" },
                new KHButtonTemplate { Name = Constants.VictoryBell, Cost = Constants.Cost250, Value = 149, ManipulationType = ManipulationType.Set, Description = "Equip Victory Bell to Donald's Weapon Slot", ImageUrl = "Staffs/Victory_Bell.png" },
                new KHButtonTemplate { Name = Constants.CometStaff, Cost = Constants.Cost300, Value = 151, ManipulationType = ManipulationType.Set, Description = "Equip Comet Staff to Donald's Weapon Slot", ImageUrl = "Staffs/Comet_Staff.png" },
                new KHButtonTemplate { Name = Constants.LordsBroom, Cost = Constants.Cost300, Value = 152, ManipulationType = ManipulationType.Set, Description = "Equip Lord's Broom to Donald's Weapon Slot", ImageUrl = "Staffs/Lords_Broom.png" },
                new KHButtonTemplate { Name = Constants.WisdomWand, Cost = Constants.Cost400, Value = 153, ManipulationType = ManipulationType.Set, Description = "Equip Wisdom Wand to Donald's Weapon Slot", ImageUrl = "Staffs/Wisdom_Wand.png" },
                new KHButtonTemplate { Name = Constants.MeteorStaff, Cost = Constants.Cost400, Value = 150, ManipulationType = ManipulationType.Set, Description = "Equip Meteor Staff to Donald's Weapon Slot", ImageUrl = "Staffs/Meteor_Staff.png" },
                new KHButtonTemplate { Name = Constants.RisingDragon, Cost = Constants.Cost500, Value = 154, ManipulationType = ManipulationType.Set, Description = "Equip Rising Dragon to Donald's Weapon Slot", ImageUrl = "Staffs/Rising_Dragon.png" },
                new KHButtonTemplate { Name = Constants.NobodyLance, Cost = Constants.Cost500, Value = 155, ManipulationType = ManipulationType.Set, Description = "Equip Nobody Lance to Donald's Weapon Slot", ImageUrl = "Staffs/Nobody_Lance.png" },
                new KHButtonTemplate { Name = Constants.ShamansRelic, Cost = Constants.Cost500, Value = 156, ManipulationType = ManipulationType.Set, Description = "Equip Shaman's Relic to Donald's Weapon Slot", ImageUrl = "Staffs/Shamans_Relic.png" },
                new KHButtonTemplate { Name = Constants.ShamansRelicPlus, Cost = Constants.Cost500, Value = 600, ManipulationType = ManipulationType.Set, Description = "Equip Shaman's Relic+ to Donald's Weapon Slot", ImageUrl = "Staffs/Shamans_RelicPlus.png" },
                new KHButtonTemplate { Name = Constants.SaveTheQueen, Cost = Constants.Cost750, Value = 482, ManipulationType = ManipulationType.Set, Description = "Equip Save the Queen to Donald's Weapon Slot", ImageUrl = "Staffs/Save_the_Queen.png" },
                new KHButtonTemplate { Name = Constants.SaveTheQueenPlus, Cost = Constants.Cost750, Value = 503, ManipulationType = ManipulationType.Set, Description = "Equip Save the Queen+ to Donald's Weapon Slot", ImageUrl = "Staffs/Save_the_QueenPlus.png" },
                new KHButtonTemplate { Name = Constants.Centurion, Cost = Constants.Cost500, Value = 545, ManipulationType = ManipulationType.Set, Description = "Equip Centurion to Donald's Weapon Slot", ImageUrl = "Staffs/Centurion.png" },
                new KHButtonTemplate { Name = Constants.CenturionPlus, Cost = Constants.Cost500, Value = 546, ManipulationType = ManipulationType.Set, Description = "Equip Centurion+ to Donald's Weapon Slot", ImageUrl = "Staffs/CenturionPlus.png" },
                new KHButtonTemplate { Name = Constants.PlainMushroom, Cost = Constants.Cost400, Value = 547, ManipulationType = ManipulationType.Set, Description = "Equip Plain Mushroom to Donald's Weapon Slot", ImageUrl = "Staffs/Plain_Mushroom.png" },
                new KHButtonTemplate { Name = Constants.PlainMushroomPlus, Cost = Constants.Cost400, Value = 548, ManipulationType = ManipulationType.Set, Description = "Equip Plain Mushroom+ to Donald's Weapon Slot", ImageUrl = "Staffs/Plain_MushroomPlus.png" },
                new KHButtonTemplate { Name = Constants.PreciousMushroom, Cost = Constants.Cost750, Value = 549, ManipulationType = ManipulationType.Set, Description = "Equip Precious Mushroom to Donald's Weapon Slot", ImageUrl = "Staffs/Precious_Mushroom.png" },
                new KHButtonTemplate { Name = Constants.PreciousMushroomPlus, Cost = Constants.Cost750, Value = 550, ManipulationType = ManipulationType.Set, Description = "Equip Precious Mushroom+ to Donald's Weapon Slot", ImageUrl = "Staffs/Precious_MushroomPlus.png" },
                new KHButtonTemplate { Name = Constants.PremiumMushroom, Cost = Constants.Cost1000, Value = 551, ManipulationType = ManipulationType.Set, Description = "Equip Premium Mushroom to Donald's Weapon Slot", ImageUrl = "Staffs/Premium_Mushroom.png" },
                new KHButtonTemplate { Name = Constants.StaffOfDetection, Cost = Constants.Cost750, Value = 161, ManipulationType = ManipulationType.Set, Description = "Equip Staff of Detection to Donald's Weapon Slot", ImageUrl = "Staffs/Staff_of_Detection.png" }
            };

            var options = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Equip Staff",
                    Category = GroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Staff to have Donald Wield",
                    ImageUrl = "Staffs/Mages_Staff.png",
                    SubMethodParams = staffs.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Equip Staff")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEquipStaffMessage));

            return options;
        }
    }
}