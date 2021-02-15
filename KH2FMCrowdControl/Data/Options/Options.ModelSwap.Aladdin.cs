using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeAladdinModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Aladdin (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Aladdin",
                    ImageUrl = "Characters/Aladdin.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Aladdin (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Aladdin",
                    ImageUrl = "Characters/Aladdin.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Aladdin (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendAladdinModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Aladdin (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendAladdinModelMessage");

            return options;
        }
    }
}