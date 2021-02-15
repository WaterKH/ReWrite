using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeBeastModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Beast (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Beast",
                    ImageUrl = "Characters/Beast.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Beast (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Beast",
                    ImageUrl = "Characters/Beast.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Beast (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendBeastModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Beast (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendBeastModelMessage");

            return options;
        }
    }
}