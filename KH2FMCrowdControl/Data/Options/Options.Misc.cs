using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeMiscOptions()
        {
            var options = new List<KHButtonTemplate>() 
            {
                new KHButtonTemplate
                {
                    Name = "Sora's Speed",
                    Category = GroupType.Misc,
                    Cost = 0,
                    Description = "Increase/ Decrease Sora's Speed",
                    ImageUrl = "Level/Normal.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = "Revert to Normal", Cost = Constants.Cost500, Value = 1090519040, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Normal", ImageUrl = "Level/Normal.png" },
                        new KHButtonTemplate { Name = "Slow Down", Cost = Constants.Cost400, Value = 1086324736, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Slow", ImageUrl = "Level/Hurt.png" },
                        new KHButtonTemplate { Name = "Slow Down x2", Cost = Constants.Cost500, Value = 1078984704, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Slow x2", ImageUrl = "Level/Hurt.png" },
                        new KHButtonTemplate { Name = "Slow Down x3", Cost = Constants.Cost1000, Value = 1073741824, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Slow x3", ImageUrl = "Level/Hurt.png" },
                        new KHButtonTemplate { Name = "Speed Up", Cost = Constants.Cost400, Value = 1103101952, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Fast", ImageUrl = "Level/Normal.png" },
                        new KHButtonTemplate { Name = "Speed Up x2", Cost = Constants.Cost500, Value = 1112539136, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Fast x2", ImageUrl = "Level/Normal.png" },
                        new KHButtonTemplate { Name = "Speed Up x3", Cost = Constants.Cost1000, Value = 1140850688, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Fast x3", ImageUrl = "Level/Normal.png" },
                    }
                },
                new KHButtonTemplate
                {
                    Name = "Munny",
                    Category = GroupType.Misc,
                    Cost = 0,
                    Description = "Give/ Take Munny",
                    ImageUrl = "Misc/Munny_Pouch.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = "Give 50 Munny", Cost = Constants.Cost100, Value = 50, ManipulationType = ManipulationType.Add, Description = "Give Sora 50 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Give 100 Munny", Cost = Constants.Cost200, Value = 100, ManipulationType = ManipulationType.Add, Description = "Give Sora 100 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Give 500 Munny", Cost = Constants.Cost250, Value = 500, ManipulationType = ManipulationType.Add, Description = "Give Sora 500 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Give 1000 Munny", Cost = Constants.Cost300, Value = 1000, ManipulationType = ManipulationType.Add, Description = "Give Sora 1000 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Give 5000 Munny", Cost = Constants.Cost400, Value = 5000, ManipulationType = ManipulationType.Add, Description = "Give Sora 5000 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Give 9999 Munny", Cost = Constants.Cost500, Value = 9999, ManipulationType = ManipulationType.Add, Description = "Give Sora 9999 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Give 99999 Munny", Cost = Constants.Cost750, Value = 99999, ManipulationType = ManipulationType.Add, Description = "Give Sora 99999 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Take 50 Munny", Cost = Constants.Cost100, Value = 50, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 50 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Take 100 Munny", Cost = Constants.Cost200, Value = 100, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 100 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Take 500 Munny", Cost = Constants.Cost250, Value = 500, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 500 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Take 1000 Munny", Cost = Constants.Cost300, Value = 1000, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1000 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Take 5000 Munny", Cost = Constants.Cost500, Value = 5000, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5000 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Take 9999 Munny", Cost = Constants.Cost750, Value = 9999, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 9999 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new KHButtonTemplate { Name = "Take 99999 Munny", Cost = Constants.Cost1000, Value = 99999, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99999 Munny", ImageUrl = "Misc/Munny_Pouch.png" }
                    }
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Munny")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage));

            return options;
        }
    }
}