using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSoraEquipmentOptions()
        {
            var options = new List<KHButtonTemplate>();

            options.AddRange(await this.InitializeSoraWeaponsOptions());
            options.AddRange(await this.InitializeSoraArmorOptions());
            options.AddRange(await this.InitializeSoraAccessoriesOptions());
            options.AddRange(await this.InitializeSoraItemsOptions());

            return options;
        }
    }
}