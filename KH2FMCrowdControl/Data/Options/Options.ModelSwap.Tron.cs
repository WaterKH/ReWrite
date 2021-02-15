using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeTronModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Tron (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Tron",
                    ImageUrl = "Characters/Tron.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Tron (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Tron",
                    ImageUrl = "Characters/Tron.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Tron (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendTronModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Tron (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendTronModelMessage");

            return options;
        }
    }
}