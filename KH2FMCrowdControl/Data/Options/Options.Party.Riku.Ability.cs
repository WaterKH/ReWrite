﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeRikuAbilityOptions()
        {
            List<ButtonTemplate> abilities = new List<ButtonTemplate>();

            AbilityMappings.RikuAbilities.Values.ToList().ForEach(x => abilities.Add(new ButtonTemplate { Name = x.Name, Cost = Constants.Cost750, Value = x.Name, ManipulationType = ManipulationType.Set, ImageUrl = "Misc/Ability.png" }));

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Activate Ability",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Riku,
                    Cost = 0,
                    Description = "Activate Riku's Ability",
                    ImageUrl = "Misc/Ability.png",
                    SubMethodParams = abilities.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Deactivate Ability",
                    Category = GroupType.Party,
                    SubCategory = SubGroupType.Riku,
                    Cost = 0,
                    Description = "Deactivate Riku's Ability",
                    ImageUrl = "Misc/Ability.png",
                    SubMethodParams = abilities.CreateListFromList()
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Activate Ability")).SubMethodParams.ForEach(x => x.MethodName = "SendRikuActivateAbilityMessage");
            options.FirstOrDefault(x => x.Name.Equals("Deactivate Ability")).SubMethodParams.ForEach(x => x.MethodName = "SendRikuDeactivateAbilityMessage");

            return options;
        }
    }
}