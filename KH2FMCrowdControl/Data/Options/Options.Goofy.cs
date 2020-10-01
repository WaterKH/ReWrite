using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeGoofyOptions()
        {
            var items = new List<KHButtonTemplate>();

            items.AddRange(await this.InitializeGoofyEquipmentOptions());

            return items;
        }
    }
}