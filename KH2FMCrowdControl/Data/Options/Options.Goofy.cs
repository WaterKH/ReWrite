﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeGoofyOptions()
        {
            var options = new List<KHButtonTemplate>();

            options.AddRange(await this.InitializeGoofyEquipmentOptions());

            return options;
        }
    }
}