using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSimbaEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            //options.AddRange(await this.InitializeSimbaWeaponsOptions());
            //options.AddRange(await this.InitializeSimbaArmorOptions());
            options.AddRange(await this.InitializeSimbaAccessoriesOptions());
            options.AddRange(await this.InitializeSimbaItemsOptions());

            return options;
        }
    }
}