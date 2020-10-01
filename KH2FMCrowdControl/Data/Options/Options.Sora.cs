using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSoraOptions()
        {
            var items = new List<KHButtonTemplate>();

            items.AddRange(await this.InitializeSoraEquipmentOptions());
            items.AddRange(await this.InitializeSoraStatsOptions());
            items.AddRange(await this.InitializeSoraMagicOptions());

            return items;
        }
    }
}