﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeDonaldOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeDonaldEquipmentOptions());
            options.AddRange(await this.InitializeDonaldAbilityOptions());

            return options;
        }
    }
}