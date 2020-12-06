using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeGoofyEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeGoofyWeaponsOptions());
            options.AddRange(await this.InitializeGoofyArmorOptions());
            options.AddRange(await this.InitializeGoofyAccessoriesOptions());
            options.AddRange(await this.InitializeGoofyItemsOptions());

            return options;
        }
    }
}