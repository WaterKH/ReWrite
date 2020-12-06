using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeDonaldEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeDonaldWeaponsOptions());
            options.AddRange(await this.InitializeDonaldArmorOptions());
            options.AddRange(await this.InitializeDonaldAccessoriesOptions());
            options.AddRange(await this.InitializeDonaldItemsOptions());

            return options;
        }
    }
}