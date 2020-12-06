using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeTronEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            //options.AddRange(await this.InitializeTronWeaponsOptions());
            options.AddRange(await this.InitializeTronArmorOptions());
            options.AddRange(await this.InitializeTronAccessoriesOptions());
            options.AddRange(await this.InitializeTronItemsOptions());

            return options;
        }
    }
}