using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeBeastEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            //options.AddRange(await this.InitializeBeastWeaponsOptions());
            //options.AddRange(await this.InitializeBeastArmorOptions());
            options.AddRange(await this.InitializeBeastAccessoriesOptions());
            options.AddRange(await this.InitializeBeastItemsOptions());

            return options;
        }
    }
}