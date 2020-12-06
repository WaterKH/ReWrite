using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeAuronEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            //options.AddRange(await this.InitializeAuronWeaponsOptions());
            options.AddRange(await this.InitializeAuronArmorOptions());
            //options.AddRange(await this.InitializeAuronAccessoriesOptions());
            options.AddRange(await this.InitializeAuronItemsOptions());

            return options;
        }
    }
}