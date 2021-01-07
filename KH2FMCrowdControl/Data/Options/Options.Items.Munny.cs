using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeMunnyOptions()
        {
            var options = new List<ButtonTemplate>()
            {
                new ButtonTemplate
                {
                    Name = "Munny",
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Munny,
                    Cost = 0,
                    Description = "Give/ Take Munny",
                    ImageUrl = "Items/Give/Items/Munny7.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 50 Munny", Cost = Constants.Cost100, Value = 50, ManipulationType = ManipulationType.Add, Description = "Give Sora 50 Munny", ImageUrl = "Items/Give/Items/Munny1.png" },
                        new ButtonTemplate { Name = "Give 100 Munny", Cost = Constants.Cost200, Value = 100, ManipulationType = ManipulationType.Add, Description = "Give Sora 100 Munny", ImageUrl = "Items/Give/Items/Munny2.png" },
                        new ButtonTemplate { Name = "Give 500 Munny", Cost = Constants.Cost250, Value = 500, ManipulationType = ManipulationType.Add, Description = "Give Sora 500 Munny", ImageUrl = "Items/Give/Items/Munny3.png" },
                        new ButtonTemplate { Name = "Give 1000 Munny", Cost = Constants.Cost300, Value = 1000, ManipulationType = ManipulationType.Add, Description = "Give Sora 1000 Munny", ImageUrl = "Items/Give/Items/Munny4.png" },
                        new ButtonTemplate { Name = "Give 5000 Munny", Cost = Constants.Cost400, Value = 5000, ManipulationType = ManipulationType.Add, Description = "Give Sora 5000 Munny", ImageUrl = "Items/Give/Items/Munny5.png" },
                        new ButtonTemplate { Name = "Give 9999 Munny", Cost = Constants.Cost500, Value = 9999, ManipulationType = ManipulationType.Add, Description = "Give Sora 9999 Munny", ImageUrl = "Items/Give/Items/Munny6.png" },
                        new ButtonTemplate { Name = "Give 99999 Munny", Cost = Constants.Cost750, Value = 99999, ManipulationType = ManipulationType.Add, Description = "Give Sora 99999 Munny", ImageUrl = "Items/Give/Items/Munny7.png" },
                        new ButtonTemplate { Name = "Take 50 Munny", Cost = Constants.Cost100, Value = 50, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 50 Munny", ImageUrl = "Items/Take/Items/Munny1TAKE.png" },
                        new ButtonTemplate { Name = "Take 100 Munny", Cost = Constants.Cost200, Value = 100, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 100 Munny", ImageUrl = "Items/Take/Items/Munny2TAKE.png" },
                        new ButtonTemplate { Name = "Take 500 Munny", Cost = Constants.Cost250, Value = 500, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 500 Munny", ImageUrl = "Items/Take/Items/Munny3TAKE.png" },
                        new ButtonTemplate { Name = "Take 1000 Munny", Cost = Constants.Cost300, Value = 1000, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1000 Munny", ImageUrl = "Items/Take/Items/Munny4TAKE.png" },
                        new ButtonTemplate { Name = "Take 5000 Munny", Cost = Constants.Cost500, Value = 5000, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5000 Munny", ImageUrl = "Items/Take/Items/Munny5TAKE.png" },
                        new ButtonTemplate { Name = "Take 9999 Munny", Cost = Constants.Cost750, Value = 9999, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 9999 Munny", ImageUrl = "Items/Take/Items/Munny6TAKE.png" },
                        new ButtonTemplate { Name = "Take 99999 Munny", Cost = Constants.Cost1000, Value = 99999, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99999 Munny", ImageUrl = "Items/Take/Items/Munny7TAKE.png" }
                    }
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Munny")).SubMethodParams.ForEach(x => x.MethodName = "SendMunnyMessage");

            return options;
        }
    }
}