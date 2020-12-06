using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeMulanEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            //options.AddRange(await this.InitializeMulanWeaponsOptions());
            options.AddRange(await this.InitializeMulanArmorOptions());
            options.AddRange(await this.InitializeMulanAccessoriesOptions());
            options.AddRange(await this.InitializeMulanItemsOptions());

            return options;
        }
    }
}