using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeAuronModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Auron (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Auron",
                    ImageUrl = "Characters/Auron.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Auron (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Auron",
                    ImageUrl = "Characters/Auron.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Auron (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendAuronModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Auron (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendAuronModelMessage");

            return options;
        }
    }
}