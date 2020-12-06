using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeAladdinOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeAladdinEquipmentOptions());
            options.AddRange(await this.InitializeAladdinAbilityOptions());

            return options;
        }
    }
}