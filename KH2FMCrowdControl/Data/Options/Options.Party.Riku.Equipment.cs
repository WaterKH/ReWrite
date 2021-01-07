using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeRikuEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            //options.AddRange(await this.InitializeRikuWeaponsOptions());
            options.AddRange(await this.InitializeRikuArmorOptions());
            options.AddRange(await this.InitializeRikuAccessoriesOptions());
            options.AddRange(await this.InitializeRikuItemsOptions());

            return options;
        }
    }
}