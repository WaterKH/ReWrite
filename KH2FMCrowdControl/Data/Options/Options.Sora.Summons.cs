using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSoraSummonOptions()
        {
            var options = new List<ButtonTemplate>() {

                new ButtonTemplate
                {
                    Name = "Give/ Take Summons",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Summon,
                    Cost = 0,
                    Description = "Give or Take Sora's Summons",
                    ImageUrl = "Items/Give/Summons/Baseball_Charm.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = Constants.Give(Constants.UkuleleCharm), Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Ukulele Charm to Sora", ImageUrl = "Items/Give/Summons/Ukulele_Charm.png", MethodName = "SendUkuleleBaseballMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.UkuleleCharm), Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Ukulele Charm from Sora", ImageUrl = "Items/Take/Summons/Ukulele_Charm.png", MethodName = "SendUkuleleBaseballMessage" },
                        new ButtonTemplate { Name = Constants.Give(Constants.BaseballCharm), Cost = Constants.Cost750, Value = 8, ManipulationType = ManipulationType.Add, Description = "Give Baseball Charm to Sora", ImageUrl = "Items/Give/Summons/Baseball_Charm.png", MethodName = "SendUkuleleBaseballMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.BaseballCharm), Cost = Constants.Cost750, Value = 8, ManipulationType = ManipulationType.Subtract, Description = "Take Baseball Charm from Sora", ImageUrl = "Items/Take/Summons/Baseball_Charm.png", MethodName = "SendUkuleleBaseballMessage" },
                        new ButtonTemplate { Name = Constants.Give(Constants.LampCharm), Cost = Constants.Cost750, Value = 16, ManipulationType = ManipulationType.Add, Description = "Give Lamp Charm to Sora", ImageUrl = "Items/Give/Summons/Lamp_Charm.png", MethodName = "SendLampFeatherMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.LampCharm), Cost = Constants.Cost750, Value = 16, ManipulationType = ManipulationType.Subtract, Description = "Take Lamp Charm from Sora", ImageUrl = "Items/Take/Summons/Lamp_Charm.png", MethodName = "SendLampFeatherMessage" },
                        new ButtonTemplate { Name = Constants.Give(Constants.FeatherCharm), Cost = Constants.Cost750, Value = 32, ManipulationType = ManipulationType.Add, Description = "Give Feather Charm to Sora", ImageUrl = "Items/Give/Summons/Feather_Charm.png", MethodName = "SendLampFeatherMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.FeatherCharm), Cost = Constants.Cost750, Value = 32, ManipulationType = ManipulationType.Subtract, Description = "Take Feather Charm from Sora", ImageUrl = "Items/Take/Summons/Feather_Charm.png", MethodName = "SendLampFeatherMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Summon Timer",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Summon,
                    Cost = 0,
                    Description = "Give or Take from Sora's Summon Timer",
                    ImageUrl = "Sora/Drive/SetFORM.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Set Summon Timer 0", Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Sets Summon Timer to 0", ImageUrl = "Sora/Drive/SetFORM0.png", MethodName = "SendDriveTimeMessage" },
                        new ButtonTemplate { Name = "Set Summon Timer Max", Cost = Constants.Cost500, Value = 5000, ManipulationType = ManipulationType.Set, Description = "Sets Summon Timer to Current Max", ImageUrl = "Sora/Drive/SetFORM9.png", MethodName = "SendDriveTimeMessage" },
                    }
                }
            };

            return options;
        }
    }
}