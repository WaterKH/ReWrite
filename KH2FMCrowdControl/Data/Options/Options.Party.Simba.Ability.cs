using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Mappings;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSimbaAbilityOptions()
        {
            List<ButtonTemplate> abilities = new List<ButtonTemplate>();

            AbilityMapping.SimbaAbilities.Values.ToList().ForEach(x => abilities.Add(new ButtonTemplate { Name = x.Name, Cost = Constants.Cost750, Value = x.Name, ManipulationType = ManipulationType.Set, ImageUrl = x.AbilityType.ToString() }));

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Activate Ability",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Simba,
                    Cost = 0,
                    Description = "Activate Simba's Ability",
                    ImageUrl = "Shared/Ability/AbilityGIVE.png",
                    SubMethodParams = abilities.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Deactivate Ability",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Simba,
                    Cost = 0,
                    Description = "Deactivate Simba's Ability",
                    ImageUrl = "Shared/Ability/AbilityTAKE.png",
                    SubMethodParams = abilities.CreateListFromList()
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Activate Ability")).SubMethodParams.ForEach(x => { x.MethodName = "SendSimbaActivateAbilityMessage"; x.ImageUrl = $"Shared/Ability/GIVE{x.ImageUrl}.png"; });
            options.FirstOrDefault(x => x.Name.Equals("Deactivate Ability")).SubMethodParams.ForEach(x => { x.MethodName = "SendSimbaDeactivateAbilityMessage"; x.ImageUrl = $"Shared/Ability/TAKE{x.ImageUrl}.png"; });

            return options;
        }
    }
}