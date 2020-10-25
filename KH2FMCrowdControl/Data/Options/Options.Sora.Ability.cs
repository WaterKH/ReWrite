using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSoraAbilityOptions()
        {
            List<KHButtonTemplate> abilities = new List<KHButtonTemplate>();

            AbilityMappings.Abilities.Values.ToList().ForEach(x => abilities.Add(new KHButtonTemplate { Name = x.Name, Cost = Constants.Cost750, Value = x, ManipulationType = ManipulationType.Set, ImageUrl = "Misc/Ability.png" }));

            var options = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Activate Ability",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Activate Sora's Ability",
                    ImageUrl = "Misc/Ability.png",
                    SubMethodParams = abilities.CreateListFromList()
                },
                new KHButtonTemplate
                {
                    Name = "Deactivate Ability",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Deactivate Sora's Ability",
                    ImageUrl = "Misc/Ability.png",
                    SubMethodParams = abilities.CreateListFromList()
                },
            };
            
            options.FirstOrDefault(x => x.Name.Equals("Activate Ability")).SubMethodParams.ForEach(x => 
            {
                x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraActivateAbilityMessage);
                x.Description = $"Activate {x.Name}";
            });

            options.FirstOrDefault(x => x.Name.Equals("Deactivate Ability")).SubMethodParams.ForEach(x =>
            {
                x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraDeactivateAbilityMessage);
                x.Description = $"Deactivate {x.Name}";
            });

            return options;
        }
    }
}