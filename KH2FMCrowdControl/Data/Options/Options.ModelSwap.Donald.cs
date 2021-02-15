using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeDonaldModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Donald (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Donald",
                    ImageUrl = "Characters/Donald.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Donald (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Donald",
                    ImageUrl = "Characters/Donald.png",
                    SubMethodParams = enemy
                },
                new ButtonTemplate
                {
                    Name = "Change Halloween Donald (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Halloween Donald",
                    ImageUrl = "Characters/HalloweenDonald.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Halloween Donald (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Halloween Donald",
                    ImageUrl = "Characters/HalloweenDonald.png",
                    SubMethodParams = enemy.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Christmas Donald (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Christmas Donald",
                    ImageUrl = "Characters/ChristmasDonald.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Christmas Donald (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Christmas Donald",
                    ImageUrl = "Characters/ChristmasDonald.png",
                    SubMethodParams = enemy.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Bird Donald (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Bird Donald",
                    ImageUrl = "Characters/Bird_Donald.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Bird Donald (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Bird Donald",
                    ImageUrl = "Characters/Bird_Donald.png",
                    SubMethodParams = enemy.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Space Paranoids Donald (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Space Paranoids Donald",
                    ImageUrl = "Characters/SpaceParanoidsDonald.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Space Paranoids Donald (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Space Paranoids Donald",
                    ImageUrl = "Characters/SpaceParanoidsDonald.png",
                    SubMethodParams = enemy.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Timeless River Donald (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Timeless River Donald",
                    ImageUrl = "Characters/TimelessRiverDonald.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Timeless River Donald (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Donald,
                    Cost = 0,
                    Description = "Choose which Character will replace Timeless River Donald",
                    ImageUrl = "Characters/TimelessRiverDonald.png",
                    SubMethodParams = enemy.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Donald (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Donald (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Halloween Donald (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendHalloweenDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Halloween Donald (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendHalloweenDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Christmas Donald (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendChristmasDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Christmas Donald (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendChristmasDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Bird Donald (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendBirdDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Bird Donald (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendBirdDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Space Paranoids Donald (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendSpaceParanoidsDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Space Paranoids Donald (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendSpaceParanoidsDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Timeless River Donald (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendTimelessRiverDonaldModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Timeless River Donald (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendTimelessRiverDonaldModelMessage");

            return options;
        }
    }
}