using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeJackSkellingtonEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            //options.AddRange(await this.InitializeJackSkellingtonWeaponsOptions());
            //options.AddRange(await this.InitializeJackSkellingtonArmorOptions());
            options.AddRange(await this.InitializeJackSkellingtonAccessoriesOptions());
            options.AddRange(await this.InitializeJackSkellingtonItemsOptions());

            return options;
        }
    }
}