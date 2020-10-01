using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSoraEquipmentOptions()
        {
            var items = new List<KHButtonTemplate>();

            items.AddRange(await this.InitializeSoraWeaponsOptions());
            items.AddRange(await this.InitializeSoraArmorOptions());
            items.AddRange(await this.InitializeSoraAccessoriesOptions());
            items.AddRange(await this.InitializeSoraItemsOptions());

            return items;
        }
    }
}