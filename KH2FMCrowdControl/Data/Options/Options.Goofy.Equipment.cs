using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeGoofyEquipmentOptions()
        {
            var items = new List<KHButtonTemplate>();

            items.AddRange(await this.InitializeGoofyWeaponsOptions());
            items.AddRange(await this.InitializeGoofyArmorOptions());
            items.AddRange(await this.InitializeGoofyAccessoriesOptions());
            items.AddRange(await this.InitializeGoofyItemsOptions());

            return items;
        }
    }
}