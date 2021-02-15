using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeRikuModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Riku (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Riku",
                    ImageUrl = "Characters/Riku.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Riku (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Riku",
                    ImageUrl = "Characters/Riku.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Riku (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendRikuModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Riku (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendRikuModelMessage");

            return options;
        }
    }
}