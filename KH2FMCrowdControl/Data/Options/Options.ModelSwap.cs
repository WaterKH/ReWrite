using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeModelSwapOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeSoraModelSwapOptions());
            options.AddRange(await this.InitializeDonaldModelSwapOptions());
            options.AddRange(await this.InitializeGoofyModelSwapOptions());

            return options;
        }
    }
}
