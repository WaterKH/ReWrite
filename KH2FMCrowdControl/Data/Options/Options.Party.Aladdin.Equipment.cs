using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeAladdinEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            //options.AddRange(await this.InitializeAladdinWeaponsOptions());
            options.AddRange(await this.InitializeAladdinArmorOptions());
            //options.AddRange(await this.InitializeAladdinAccessoriesOptions());
            options.AddRange(await this.InitializeAladdinItemsOptions());

            return options;
        }
    }
}