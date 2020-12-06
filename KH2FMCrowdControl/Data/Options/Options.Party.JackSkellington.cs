using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeJackSkellingtonOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeJackSkellingtonEquipmentOptions());
            options.AddRange(await this.InitializeJackSkellingtonAbilityOptions());

            return options;
        }
    }
}