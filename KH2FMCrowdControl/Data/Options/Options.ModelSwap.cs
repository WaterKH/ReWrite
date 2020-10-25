using System.Collections.Generic;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeModelSwapOptions()
        {
            var options = new List<KHButtonTemplate>();

            options.AddRange(await this.InitializeSoraModelSwapOptions());
            options.AddRange(await this.InitializeDonaldModelSwapOptions());
            options.AddRange(await this.InitializeGoofyModelSwapOptions());

            return options;
        }
    }
}
