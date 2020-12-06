using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeCaptainJackSparrowEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            //options.AddRange(await this.InitializeCaptainJackSparrowWeaponsOptions());
            options.AddRange(await this.InitializeCaptainJackSparrowArmorOptions());
            options.AddRange(await this.InitializeCaptainJackSparrowAccessoriesOptions());
            options.AddRange(await this.InitializeCaptainJackSparrowItemsOptions());

            return options;
        }
    }
}