using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public class KHButtonTemplate
    {
        public string Name { get; set; }
        public GroupType Category { get; set; }
        public SubGroupType SubCategory { get; set; }
        public int Cost { get; set; }
        public bool IsDisabled { get; set; }
        public object Value { get; set; }
        public ManipulationType ManipulationType { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public EventCallback<MemoryParameters> Method { get; set; }
        public List<KHButtonTemplate> SubMethodParams { get; set; }
        public bool IsActive { get; set; } = true;
    }
}