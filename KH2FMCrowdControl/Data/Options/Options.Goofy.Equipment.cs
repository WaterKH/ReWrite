using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeGoofyEquipmentOptions()
        {
            var options = new List<KHButtonTemplate>();

            options.AddRange(await this.InitializeGoofyWeaponsOptions());
            options.AddRange(await this.InitializeGoofyArmorOptions());
            options.AddRange(await this.InitializeGoofyAccessoriesOptions());
            options.AddRange(await this.InitializeGoofyItemsOptions());

            return options;
        }
    }
}