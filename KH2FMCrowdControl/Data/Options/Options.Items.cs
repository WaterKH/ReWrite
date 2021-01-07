using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeItemOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeBaseItemsOptions());
            options.AddRange(await this.InitializeWeaponsOptions());
            options.AddRange(await this.InitializeArmorOptions());
            options.AddRange(await this.InitializeAccessoriesOptions());
            options.AddRange(await this.InitializeMunnyOptions());

            return options;
        }
    }
}