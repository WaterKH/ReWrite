using System.Collections.Generic;
using System.Linq;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public static class Extensions
    {
        public static List<ButtonTemplate> CreateListFromList(this List<ButtonTemplate> list)
        {
            return list.Select(keyblade => new ButtonTemplate
            {
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