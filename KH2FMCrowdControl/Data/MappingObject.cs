using Microsoft.AspNetCore.Components;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public class MappingObject
    {
        public MemoryObject MemoryObject { get; set; }
        public GroupType Category { get; set; }
        public SubGroupType SubCategory { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public EventCallback Method { get; set; }
    }
}