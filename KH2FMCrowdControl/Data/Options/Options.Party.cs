using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializePartyOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await InitializeDonaldOptions());
            options.AddRange(await InitializeGoofyOptions());
            options.AddRange(await InitializeMulanOptions());
            options.AddRange(await InitializeBeastOptions());
            options.AddRange(await InitializeAuronOptions());
            options.AddRange(await InitializeCaptainJackSparrowOptions());
            options.AddRange(await InitializeAladdinOptions());
            options.AddRange(await InitializeJackSkellingtonOptions());
            options.AddRange(await InitializeSimbaOptions());
            options.AddRange(await InitializeTronOptions());
            options.AddRange(await InitializeRikuOptions());

            return options;
        }
    }
}