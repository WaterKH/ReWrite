using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSoraOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeSoraEquipmentOptions());
            options.AddRange(await this.InitializeSoraStatsOptions());
            options.AddRange(await this.InitializeSoraMagicOptions());
            options.AddRange(await this.InitializeSoraDriveOptions());
            options.AddRange(await this.InitializeSoraSummonOptions());
            options.AddRange(await this.InitializeSoraAbilityOptions());

            return options;
        }
    }
}