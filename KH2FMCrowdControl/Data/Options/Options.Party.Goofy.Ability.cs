using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeGoofyAbilityOptions()
        {
            List<ButtonTemplate> abilities = new List<ButtonTemplate>();

            AbilityMappings.GoofyAbilities.Values.ToList().ForEach(x => abilities.Add(new ButtonTemplate { Name = x.Name, Cost = Constants.Cost750, Value = x.Name, ManipulationType = ManipulationType.Set, ImageUrl = "Misc/Ability.png" }));

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Activate Ability",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Activate Goofy's Ability",
                    ImageUrl = "Misc/Ability.png",
                    SubMethodParams = abilities.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Deactivate Ability",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Goofy,
                    Cost = 0,
                    Description = "Deactivate Goofy's Ability",
                    ImageUrl = "Misc/Ability.png",
                    SubMethodParams = abilities.CreateListFromList()
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Activate Ability")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyActivateAbilityMessage");
            options.FirstOrDefault(x => x.Name.Equals("Deactivate Ability")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyDeactivateAbilityMessage");

            return options;
        }
    }
}