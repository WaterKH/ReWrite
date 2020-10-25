using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSoraOptions()
        {
            var options = new List<KHButtonTemplate>();

            options.AddRange(await this.InitializeSoraEquipmentOptions());
            options.AddRange(await this.InitializeSoraStatsOptions());
            options.AddRange(await this.InitializeSoraMagicOptions());
            options.AddRange(await this.InitializeSoraAbilityOptions());

            return options;
        }
    }
}