using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeItemOptions()
        {
            var items = new List<KHButtonTemplate>();

            items.AddRange(await this.InitializeBaseItemsOptions());
            items.AddRange(await this.InitializeWeaponsOptions());
            items.AddRange(await this.InitializeArmorOptions());
            items.AddRange(await this.InitializeAccessoriesOptions());

            return items;
        }
    }
}