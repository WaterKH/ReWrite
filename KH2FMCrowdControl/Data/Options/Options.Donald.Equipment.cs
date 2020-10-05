using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeDonaldEquipmentOptions()
        {
            var options = new List<KHButtonTemplate>();

            options.AddRange(await this.InitializeDonaldWeaponsOptions());
            options.AddRange(await this.InitializeDonaldArmorOptions());
            options.AddRange(await this.InitializeDonaldAccessoriesOptions());
            options.AddRange(await this.InitializeDonaldItemsOptions());

            return options;
        }
    }
}