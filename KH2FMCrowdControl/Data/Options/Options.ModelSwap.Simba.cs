using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSimbaModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Simba (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Simba",
                    ImageUrl = "Characters/Simba.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Simba (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Simba",
                    ImageUrl = "Characters/Simba.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Simba (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendSimbaModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Simba (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendSimbaModelMessage");

            return options;
        }
    }
}