using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeCaptainJackSparrowOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeCaptainJackSparrowEquipmentOptions());
            options.AddRange(await this.InitializeCaptainJackSparrowAbilityOptions());

            return options;
        }
    }
}