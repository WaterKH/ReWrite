using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeMiscOptions()
        {
            var options = new List<ButtonTemplate>()
            {
                new ButtonTemplate
                {
                    Name = "Munny",
                    Category = GroupType.Misc,
                    Cost = 0,
                    Description = "Give/ Take Munny",
                    ImageUrl = "Misc/Munny_Pouch.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 50 Munny", Cost = Constants.Cost100, Value = 50, ManipulationType = ManipulationType.Add, Description = "Give Sora 50 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Give 100 Munny", Cost = Constants.Cost200, Value = 100, ManipulationType = ManipulationType.Add, Description = "Give Sora 100 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Give 500 Munny", Cost = Constants.Cost250, Value = 500, ManipulationType = ManipulationType.Add, Description = "Give Sora 500 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Give 1000 Munny", Cost = Constants.Cost300, Value = 1000, ManipulationType = ManipulationType.Add, Description = "Give Sora 1000 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Give 5000 Munny", Cost = Constants.Cost400, Value = 5000, ManipulationType = ManipulationType.Add, Description = "Give Sora 5000 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Give 9999 Munny", Cost = Constants.Cost500, Value = 9999, ManipulationType = ManipulationType.Add, Description = "Give Sora 9999 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Give 99999 Munny", Cost = Constants.Cost750, Value = 99999, ManipulationType = ManipulationType.Add, Description = "Give Sora 99999 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Take 50 Munny", Cost = Constants.Cost100, Value = 50, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 50 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Take 100 Munny", Cost = Constants.Cost200, Value = 100, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 100 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Take 500 Munny", Cost = Constants.Cost250, Value = 500, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 500 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Take 1000 Munny", Cost = Constants.Cost300, Value = 1000, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1000 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Take 5000 Munny", Cost = Constants.Cost500, Value = 5000, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5000 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Take 9999 Munny", Cost = Constants.Cost750, Value = 9999, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 9999 Munny", ImageUrl = "Misc/Munny_Pouch.png" },
                        new ButtonTemplate { Name = "Take 99999 Munny", Cost = Constants.Cost1000, Value = 99999, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99999 Munny", ImageUrl = "Misc/Munny_Pouch.png" }
                    }
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Munny")).SubMethodParams.ForEach(x => x.MethodName = "SendMunnyMessage");

            return options;
        }
    }
}