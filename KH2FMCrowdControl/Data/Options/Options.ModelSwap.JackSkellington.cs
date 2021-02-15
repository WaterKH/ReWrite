using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeJackSkellingtonModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Jack Skellington (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Jack Skellington",
                    ImageUrl = "Characters/Halloween_Jack.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Jack Skellington (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Jack Skellington",
                    ImageUrl = "Characters/Halloween_Jack.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Jack Skellington (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendJackSkellingtonModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Jack Skellington (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendJackSkellingtonModelMessage");

            return options;
        }
    }
}