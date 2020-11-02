using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSoraEquipmentOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeSoraWeaponsOptions());
            options.AddRange(await this.InitializeSoraArmorOptions());
            options.AddRange(await this.InitializeSoraAccessoriesOptions());
            options.AddRange(await this.InitializeSoraItemsOptions());

            return options;
        }
    }
}