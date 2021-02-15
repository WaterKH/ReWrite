using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeGoofyModelSwapOptions(List<ButtonTemplate> ally, List<ButtonTemplate> enemy)
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Goofy (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Goofy",
                    ImageUrl = "Characters/Goofy.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Goofy (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Goofy",
                    ImageUrl = "Characters/Goofy.png",
                    SubMethodParams = enemy.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Halloween Goofy (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Halloween Goofy",
                    ImageUrl = "Characters/HalloweenGoofy.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Halloween Goofy (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Halloween Goofy",
                    ImageUrl = "Characters/HalloweenGoofy.png",
                    SubMethodParams = enemy.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Christmas Goofy (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Christmas Goofy",
                    ImageUrl = "Characters/ChristmasGoofy.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Christmas Goofy (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Christmas Goofy",
                    ImageUrl = "Characters/ChristmasGoofy.png",
                    SubMethodParams = enemy.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Tortoise Goofy (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Tortoise Goofy",
                    ImageUrl = "Characters/Tortoise_Goofy.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Tortoise Goofy (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Tortoise Goofy",
                    ImageUrl = "Characters/Tortoise_Goofy.png",
                    SubMethodParams = enemy.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Space Paranoids Goofy (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Space Paranoids Goofy",
                    ImageUrl = "Characters/SpaceParanoidsGoofy.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Space Paranoids Goofy (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Space Paranoids Goofy",
                    ImageUrl = "Characters/SpaceParanoidsGoofy.png",
                    SubMethodParams = enemy.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Timeless River Goofy (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Timeless River Goofy",
                    ImageUrl = "Characters/TimelessRiverGoofy.png",
                    SubMethodParams = ally.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Timeless River Goofy (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Choose which Character will replace Timeless River Goofy",
                    ImageUrl = "Characters/TimelessRiverGoofy.png",
                    SubMethodParams = enemy.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Goofy (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Goofy (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Halloween Goofy (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendHalloweenGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Halloween Goofy (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendHalloweenGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Christmas Goofy (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendChristmasGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Christmas Goofy (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendChristmasGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Tortoise Goofy (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendTortoiseGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Tortoise Goofy (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendTortoiseGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Space Paranoids Goofy (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendSpaceParanoidsGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Space Paranoids Goofy (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendSpaceParanoidsGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Timeless River Goofy (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendTimelessRiverGoofyModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Timeless River Goofy (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendTimelessRiverGoofyModelMessage");

            return options;
        }
    }
}