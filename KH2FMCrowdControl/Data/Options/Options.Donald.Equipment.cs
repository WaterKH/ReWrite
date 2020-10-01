using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeDonaldEquipmentOptions()
        {
            var items = new List<KHButtonTemplate>();

            items.AddRange(await this.InitializeDonaldWeaponsOptions());
            items.AddRange(await this.InitializeDonaldArmorOptions());
            items.AddRange(await this.InitializeDonaldAccessoriesOptions());
            items.AddRange(await this.InitializeDonaldItemsOptions());

            return items;
        }
    }
}