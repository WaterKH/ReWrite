using System.Collections.Generic;
using System.Linq;

namespace KH2FMCrowdControl.Data
{
    public static class Extensions
    {
        public static List<KHButtonTemplate> CreateListFromList(this List<KHButtonTemplate> list)
        {
            return list.Select(keyblade => new KHButtonTemplate { 
                Name = keyblade.Name, 
                Cost = keyblade.Cost, 
                Value = keyblade.Value,
                ManipulationType = keyblade.ManipulationType,
                Description = keyblade.Description,
                ImageUrl = keyblade.ImageUrl
            }).ToList();
        }
    }
}