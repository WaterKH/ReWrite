using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeMulanModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Mulan (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Mulan",
                    ImageUrl = "Characters/Mulan.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Mulan (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Mulan",
                    ImageUrl = "Characters/Mulan.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Mulan (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendMulanModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Mulan (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendMulanModelMessage");

            return options;
        }
    }
}