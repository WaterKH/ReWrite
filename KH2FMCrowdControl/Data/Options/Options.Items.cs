using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeItemOptions()
        {
            var options = new List<KHButtonTemplate>();

            options.AddRange(await this.InitializeBaseItemsOptions());
            options.AddRange(await this.InitializeWeaponsOptions());
            options.AddRange(await this.InitializeArmorOptions());
            options.AddRange(await this.InitializeAccessoriesOptions());

            return options;
        }
    }
}