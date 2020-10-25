using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class AbilityMappings
    {
        // Key - Name : Value - Ability
        public static Dictionary<string, Ability> Abilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Slapshot", new Ability { Name = "Slapshot", Value = 6, ToggleValue = 129 } },
            { "Dodge Slash", new Ability { Name = "Dodge Slash", Value = 7, ToggleValue = 129 } },
            { "Slide Dash", new Ability { Name = "Slide Dash", Value = 8, ToggleValue = 129 } },
            { "Guard Break", new Ability { Name = "Guard Break", Value = 9, ToggleValue = 129 } },
            { "Explosion", new Ability { Name = "Explosion", Value = 10, ToggleValue = 129 } },
            { "Finishing Leap", new Ability { Name = "Finishing Leap", Value = 11, ToggleValue = 129 } },
            { "Counterguard", new Ability { Name = "Counterguard", Value = 12, ToggleValue = 129 } },
            { "Aerial Sweep", new Ability { Name = "Aerial Sweep", Value = 13, ToggleValue = 129 } },
            { "Aerial Spiral", new Ability { Name = "Aerial Spiral", Value = 14, ToggleValue = 129 } },
            { "Horizontal Slash", new Ability { Name = "Horizontal Slash", Value = 15, ToggleValue = 129 } },
            { "Aerial Finish", new Ability { Name = "Aerial Finish", Value = 16, ToggleValue = 129 } },
            { "Retaliating Slash", new Ability { Name = "Retaliating Slash", Value = 17, ToggleValue = 129 } },
            { "Aerial Dive", new Ability { Name = "Aerial Dive", Value = 48, ToggleValue = 130 } },
            { "Magnet Burst", new Ability { Name = "Magnet Burst", Value = 49, ToggleValue = 130 } },
            { "Vicinity Break", new Ability { Name = "Vicinity Break", Value = 50, ToggleValue = 130 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 56, ToggleValue = 130 } },
            { "Guard", new Ability { Name = "Guard", Value = 82, ToggleValue = 128 } },
            { "Auto Valor", new Ability { Name = "Auto Valor", Value = 129, ToggleValue = 129 } },
            { "Auto Wisdom", new Ability { Name = "Auto Wisdom", Value = 130, ToggleValue = 129 } },
            { "Auto Master", new Ability { Name = "Auto Master", Value = 131, ToggleValue = 129 } },
            { "Auto Final", new Ability { Name = "Auto Final", Value = 132, ToggleValue = 129 } },
            { "Auto Summon", new Ability { Name = "Auto Summon", Value = 133, ToggleValue = 129 } },
            { "Upper Slash", new Ability { Name = "Upper Slash", Value = 137, ToggleValue = 128 } },
            { "Trinity Limit", new Ability { Name = "Trinity Limit", Value = 198, ToggleValue = 128 } },

            #endregion Action

            #region Growth

            { "Quick Run LV1", new Ability { Name = "Quick Run LV1", Value = 94, ToggleValue = 128 } },
            { "Quick Run LV2", new Ability { Name = "Quick Run LV2", Value = 95, ToggleValue = 128 } },
            { "Quick Run LV3", new Ability { Name = "Quick Run LV3", Value = 96, ToggleValue = 128 } },
            { "Quick Run MAX", new Ability { Name = "Quick Run MAX", Value = 97, ToggleValue = 128 } },

            { "High Jump LV1", new Ability { Name = "High Jump LV1", Value = 98, ToggleValue = 128 } },
            { "High Jump LV2", new Ability { Name = "High Jump LV2", Value = 99, ToggleValue = 128 } },
            { "High Jump LV3", new Ability { Name = "High Jump LV3", Value = 100, ToggleValue = 128 } },
            { "High Jump MAX", new Ability { Name = "High Jump MAX", Value = 101, ToggleValue = 128 } },

            { "Dodge Roll LV1", new Ability { Name = "Dodge Roll LV1", Value = 52, ToggleValue = 130 } },
            { "Dodge Roll LV2", new Ability { Name = "Dodge Roll LV2", Value = 53, ToggleValue = 130 } },
            { "Dodge Roll LV3", new Ability { Name = "Dodge Roll LV3", Value = 54, ToggleValue = 130 } },
            { "Dodge Roll MAX", new Ability { Name = "Dodge Roll MAX", Value = 55, ToggleValue = 130 } },

            { "Aerial Dodge LV1", new Ability { Name = "Aerial Dodge LV1", Value = 102, ToggleValue = 128 } },
            { "Aerial Dodge LV2", new Ability { Name = "Aerial Dodge LV2", Value = 103, ToggleValue = 128 } },
            { "Aerial Dodge LV3", new Ability { Name = "Aerial Dodge LV3", Value = 104, ToggleValue = 128 } },
            { "Aerial Dodge MAX", new Ability { Name = "Aerial Dodge MAX", Value = 105, ToggleValue = 128 } },

            { "Glide LV1", new Ability { Name = "Glide LV1", Value = 106, ToggleValue = 128 } },
            { "Glide LV2", new Ability { Name = "Glide LV2", Value = 107, ToggleValue = 128 } },
            { "Glide LV3", new Ability { Name = "Glide LV3", Value = 108, ToggleValue = 128 } },
            { "Glide MAX", new Ability { Name = "Glide MAX", Value = 109, ToggleValue = 128 } },

            #endregion Growth

            #region Support
            
            { "Drive Converter", new Ability { Name = "Drive Converter", Value = 28, ToggleValue = 130 } },
            { "Damage Control", new Ability { Name = "Damage Control", Value = 30, ToggleValue = 130 } },
            { "Scan", new Ability { Name = "Scan", Value = 138, ToggleValue = 128 } },
            { "Combo Boost", new Ability { Name = "Combo Boost", Value = 134, ToggleValue = 129, MaxNumber = 2 } },
            { "Air Combo Boost", new Ability { Name = "Air Combo Boost", Value = 135, ToggleValue = 129, MaxNumber = 2 } },
            { "Reaction Boost", new Ability { Name = "Reaction Boost", Value = 136, ToggleValue = 129, MaxNumber = 3 } },
            { "Negative Combo", new Ability { Name = "Negative Combo", Value = 138, ToggleValue = 129, MaxNumber = 2 } },
            { "Drive Boost", new Ability { Name = "Drive Boost", Value = 141, ToggleValue = 129, MaxNumber = 2 } },
            { "Form Boost", new Ability { Name = "Form Boost", Value = 142, ToggleValue = 129, MaxNumber = 3 } },
            { "Summon Boost", new Ability { Name = "Summon Boost", Value = 143, ToggleValue = 129 } },
            { "Combination Boost", new Ability { Name = "Combination Boost", Value = 144, ToggleValue = 129 } },
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129, MaxNumber = 3 } },
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129 } },
            { "Fire Boost", new Ability { Name = "Fire Boost", Value = 152, ToggleValue = 129, MaxNumber = 2 } },
            { "Blizzard Boost", new Ability { Name = "Blizzard Boost", Value = 153, ToggleValue = 129, MaxNumber = 2 } },
            { "Thunder Boost", new Ability { Name = "Thunder Boost", Value = 154, ToggleValue = 129, MaxNumber = 2 } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129, MaxNumber = 2 } },
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129, MaxNumber = 2 } },
            { "MP Haste", new Ability { Name = "MP Haste", Value = 157, ToggleValue = 129 } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129 } },
            { "Aerial Recovery", new Ability { Name = "Aerial Recovery", Value = 158, ToggleValue = 128 } },
            { "Combo Plus", new Ability { Name = "Combo Plus", Value = 162, ToggleValue = 128, MaxNumber = 3 } },
            { "Air Combo Plus", new Ability { Name = "Air Combo Plus", Value = 163, ToggleValue = 128, MaxNumber = 3 } },

            #endregion Support
        };
    }
}