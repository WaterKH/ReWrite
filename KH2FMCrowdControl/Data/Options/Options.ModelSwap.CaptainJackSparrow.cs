using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeCaptainJackSparrowModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Captain Jack Sparrow (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Captain Jack Sparrow",
                    ImageUrl = "Characters/Jack_Sparrow.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Captain Jack Sparrow (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Captain Jack Sparrow",
                    ImageUrl = "Characters/Jack_Sparrow.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Captain Jack Sparrow (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendCaptainJackSparrowModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Captain Jack Sparrow (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendCaptainJackSparrowModelMessage");

            return options;
        }
    }
}