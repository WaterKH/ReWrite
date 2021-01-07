using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class AbilityMappings
    {
        // Key - Name : Value - Ability
        public static Dictionary<string, Ability> SoraAbilities = new Dictionary<string, Ability>
        {
            #region Action 
            
            { "Guard", new Ability { Name = "Guard", Value = 82, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Upper Slash", new Ability { Name = "Upper Slash", Value = 137, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Horizontal Slash", new Ability { Name = "Horizontal Slash", Value = 15, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Finishing Leap", new Ability { Name = "Finishing Leap", Value = 11, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Retaliating Slash", new Ability { Name = "Retaliating Slash", Value = 17, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Slapshot", new Ability { Name = "Slapshot", Value = 6, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Dodge Slash", new Ability { Name = "Dodge Slash", Value = 7, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Flash Step", new Ability { Name = "Flash Step", Value = 47, ToggleValue = 130, AbilityType = AbilityType.Action } },
            { "Slide Dash", new Ability { Name = "Slide Dash", Value = 8, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Vicinity Break", new Ability { Name = "Vicinity Break", Value = 50, ToggleValue = 130, AbilityType = AbilityType.Action } },
            { "Guard Break", new Ability { Name = "Guard Break", Value = 9, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Explosion", new Ability { Name = "Explosion", Value = 10, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Aerial Sweep", new Ability { Name = "Aerial Sweep", Value = 13, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Aerial Dive", new Ability { Name = "Aerial Dive", Value = 48, ToggleValue = 130, AbilityType = AbilityType.Action } },
            { "Aerial Spiral", new Ability { Name = "Aerial Spiral", Value = 14, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Aerial Finish", new Ability { Name = "Aerial Finish", Value = 16, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Magnet Burst", new Ability { Name = "Magnet Burst", Value = 49, ToggleValue = 130, AbilityType = AbilityType.Action } },
            { "Counterguard", new Ability { Name = "Counterguard", Value = 12, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Auto Valor", new Ability { Name = "Auto Valor", Value = 129, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Auto Wisdom", new Ability { Name = "Auto Wisdom", Value = 130, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 56, ToggleValue = 130, AbilityType = AbilityType.Action } },
            { "Auto Master", new Ability { Name = "Auto Master", Value = 131, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Auto Final", new Ability { Name = "Auto Final", Value = 132, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Auto Summon", new Ability { Name = "Auto Summon", Value = 133, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Trinity Limit", new Ability { Name = "Trinity Limit", Value = 198, ToggleValue = 128, AbilityType = AbilityType.Action } },

            #endregion Action

            #region Growth

            { "High Jump LV1", new Ability { Name = "High Jump LV1", Value = 94, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "High Jump LV2", new Ability { Name = "High Jump LV2", Value = 95, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "High Jump LV3", new Ability { Name = "High Jump LV3", Value = 96, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "High Jump MAX", new Ability { Name = "High Jump MAX", Value = 97, ToggleValue = 128, AbilityType = AbilityType.Growth } },

            { "Quick Run LV1", new Ability { Name = "Quick Run LV1", Value = 98, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "Quick Run LV2", new Ability { Name = "Quick Run LV2", Value = 99, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "Quick Run LV3", new Ability { Name = "Quick Run LV3", Value = 100, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "Quick Run MAX", new Ability { Name = "Quick Run MAX", Value = 101, ToggleValue = 128, AbilityType = AbilityType.Growth } },

            { "Dodge Roll LV1", new Ability { Name = "Dodge Roll LV1", Value = 52, ToggleValue = 130, AbilityType = AbilityType.Growth } },
            { "Dodge Roll LV2", new Ability { Name = "Dodge Roll LV2", Value = 53, ToggleValue = 130, AbilityType = AbilityType.Growth } },
            { "Dodge Roll LV3", new Ability { Name = "Dodge Roll LV3", Value = 54, ToggleValue = 130, AbilityType = AbilityType.Growth } },
            { "Dodge Roll MAX", new Ability { Name = "Dodge Roll MAX", Value = 55, ToggleValue = 130, AbilityType = AbilityType.Growth } },

            { "Aerial Dodge LV1", new Ability { Name = "Aerial Dodge LV1", Value = 102, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "Aerial Dodge LV2", new Ability { Name = "Aerial Dodge LV2", Value = 103, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "Aerial Dodge LV3", new Ability { Name = "Aerial Dodge LV3", Value = 104, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "Aerial Dodge MAX", new Ability { Name = "Aerial Dodge MAX", Value = 105, ToggleValue = 128, AbilityType = AbilityType.Growth } },

            { "Glide LV1", new Ability { Name = "Glide LV1", Value = 106, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "Glide LV2", new Ability { Name = "Glide LV2", Value = 107, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "Glide LV3", new Ability { Name = "Glide LV3", Value = 108, ToggleValue = 128, AbilityType = AbilityType.Growth } },
            { "Glide MAX", new Ability { Name = "Glide MAX", Value = 109, ToggleValue = 128, AbilityType = AbilityType.Growth } },

            #endregion Growth

            #region Support
           
            { "Scan", new Ability { Name = "Scan", Value = 138, ToggleValue = 128, AbilityType = AbilityType.Support } },
            { "Aerial Recovery", new Ability { Name = "Aerial Recovery", Value = 158, ToggleValue = 128, AbilityType = AbilityType.Support } },
            { "Combo Master", new Ability { Name = "Combo Master", Value = 27, ToggleValue = 130, AbilityType = AbilityType.Support } },
            { "Combo Plus", new Ability { Name = "Combo Plus", Value = 162, ToggleValue = 128, AbilityType = AbilityType.Support } },
            { "Air Combo Plus", new Ability { Name = "Air Combo Plus", Value = 163, ToggleValue = 128, MaxNumber = 2, AbilityType = AbilityType.Support } },
            { "Combo Boost", new Ability { Name = "Combo Boost", Value = 134, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Air Combo Boost", new Ability { Name = "Air Combo Boost", Value = 135, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Reaction Boost", new Ability { Name = "Reaction Boost", Value = 136, ToggleValue = 129, MaxNumber = 2, AbilityType = AbilityType.Support } },
            { "Finishing Plus", new Ability { Name = "Finishing Plus", Value = 137, ToggleValue = 129, MaxNumber = 2, AbilityType = AbilityType.Support } },
            { "Negative Combo", new Ability { Name = "Negative Combo", Value = 138, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Berserk Charge", new Ability { Name = "Berserk Charge", Value = 139, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Damage Drive", new Ability { Name = "Damage Drive", Value = 140, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Drive Boost", new Ability { Name = "Drive Boost", Value = 141, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Form Boost", new Ability { Name = "Form Boost", Value = 142, ToggleValue = 129, MaxNumber = 2, AbilityType = AbilityType.Support } },
            { "Summon Boost", new Ability { Name = "Summon Boost", Value = 143, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Combination Boost", new Ability { Name = "Combination Boost", Value = 144, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Experience Boost", new Ability { Name = "Experience Boost", Value = 145, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Leaf Bracer", new Ability { Name = "Leaf Bracer", Value = 146, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Magic Lock-On", new Ability { Name = "Magic Lock-On", Value = 147, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129, MaxNumber = 3, AbilityType = AbilityType.Support } },
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129, MaxNumber = 2, AbilityType = AbilityType.Support } },
            { "Drive Converter", new Ability { Name = "Drive Converter", Value = 28, ToggleValue = 130, AbilityType = AbilityType.Support } },
            { "Fire Boost", new Ability { Name = "Fire Boost", Value = 152, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Blizzard Boost", new Ability { Name = "Blizzard Boost", Value = 153, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Thunder Boost", new Ability { Name = "Thunder Boost", Value = 154, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Hastera", new Ability { Name = "MP Hastera", Value = 165, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Damage Control", new Ability { Name = "Damage Control", Value = 30, ToggleValue = 130, AbilityType = AbilityType.Support } },
            { "Second Chance", new Ability { Name = "Second Chance", Value = 129, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "No Experience", new Ability { Name = "No Experience", Value = 148, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> DonaldAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Donald Fire", new Ability { Name = "Donald Fire", Value = 165, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Donald Blizzard", new Ability { Name = "Donald Blizzard", Value = 166, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Donald Thunder", new Ability { Name = "Donald Thunder", Value = 167, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Donald Cure", new Ability { Name = "Donald Cure", Value = 168, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Fantasia", new Ability { Name = "Fantasia", Value = 199, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Flare Force", new Ability { Name = "Flare Force", Value = 200, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Fire Boost", new Ability { Name = "Fire Boost", Value = 152, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Blizzard Boost", new Ability { Name = "Blizzard Boost", Value = 153, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Thunder Boost", new Ability { Name = "Thunder Boost", Value = 154, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Hastera", new Ability { Name = "MP Hastera", Value = 165, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> GoofyAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Goofy Tornado", new Ability { Name = "Goofy Tornado", Value = 167, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Goofy Bash", new Ability { Name = "Goofy Bash", Value = 173, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Goofy Turbo", new Ability { Name = "Goofy Turbo", Value = 169, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Tornado Fusion", new Ability { Name = "Tornado Fusion", Value = 201, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Teamwork", new Ability { Name = "Teamwork", Value = 202, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Damage Control", new Ability { Name = "Damage Control", Value = 30, ToggleValue = 130, AbilityType = AbilityType.Support } },
            { "Second Chance", new Ability { Name = "Second Chance", Value = 159, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Change", new Ability { Name = "Auto Change", Value = 162, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> MulanAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Mushu Fire", new Ability { Name = "Mushu Fire", Value = 178, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Flametongue", new Ability { Name = "Flametongue", Value = 179, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Dragonblaze", new Ability { Name = "Dragonblaze", Value = 207, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Fire Boost", new Ability { Name = "Fire Boost", Value = 152, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> BeastAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Furious Shout", new Ability { Name = "Furious Shout", Value = 177, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Ferocious Rush", new Ability { Name = "Ferocious Rush", Value = 174, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Howling Moon", new Ability { Name = "Howling Moon", Value = 205, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Second Chance", new Ability { Name = "Second Chance", Value = 159, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> AuronAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Divider", new Ability { Name = "Divider", Value = 172, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Healing Water", new Ability { Name = "Healing Water", Value = 176, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Overdrive", new Ability { Name = "Overdrive", Value = 204, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Haste", new Ability { Name = "MP Haste", Value = 157, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> CaptainJackSparrowAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "No Mercy", new Ability { Name = "No Mercy", Value = 190, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Rain Storm", new Ability { Name = "Rain Storm", Value = 191, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Bone Smash", new Ability { Name = "Bone Smash", Value = 192, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Treasure Isle", new Ability { Name = "Treasure Isle", Value = 210, ToggleValue = 128, AbilityType = AbilityType.Action } },

            #endregion Action

            #region Support
            
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129, MaxNumber = 3, AbilityType = AbilityType.Support } },
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> AladdinAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Slash Frenzy", new Ability { Name = "Slash Frenzy", Value = 170, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Quickplay", new Ability { Name = "Quickplay", Value = 171, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Trick Fantasy", new Ability { Name = "Trick Fantasy", Value = 203, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Haste", new Ability { Name = "MP Haste", Value = 157, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Change", new Ability { Name = "Auto Change", Value = 162, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> JackSkellingtonAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Blazing Fury", new Ability { Name = "Blazing Fury", Value = 175, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Icy Terror", new Ability { Name = "Icy Terror", Value = 176, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Bolts of Sorrow", new Ability { Name = "Bolts of Sorrow", Value = 177, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Aplause, Aplause", new Ability { Name = "Aplause, Aplause", Value = 206, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Fire Boost", new Ability { Name = "Fire Boost", Value = 152, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Blizzard Boost", new Ability { Name = "Blizzard Boost", Value = 153, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Thunder Boost", new Ability { Name = "Thunder Boost", Value = 154, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Hastera", new Ability { Name = "MP Hastera", Value = 165, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> SimbaAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Fierce Claw", new Ability { Name = "Fierce Claw", Value = 183, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Groundshaker", new Ability { Name = "Groundshaker", Value = 182, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Healing Herb", new Ability { Name = "Healing Herb", Value = 190, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "King's Pride", new Ability { Name = "King's Pride", Value = 209, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> TronAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Scouting Disk", new Ability { Name = "Scouting Disk", Value = 188, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Pulsing Thunder", new Ability { Name = "Pulsing Thunder", Value = 215, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Complete Compilment", new Ability { Name = "Complete Compilment", Value = 211, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Thunder Boost", new Ability { Name = "Thunder Boost", Value = 154, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Haste", new Ability { Name = "MP Haste", Value = 157, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Change", new Ability { Name = "Auto Change", Value = 162, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> RikuAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Dark Aura", new Ability { Name = "Dark Aura", Value = 182, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Dark Shield", new Ability { Name = "Dark Shield", Value = 180, ToggleValue = 129, AbilityType = AbilityType.Action } },
            { "Cure Potion", new Ability { Name = "Cure Potion", Value = 187, ToggleValue = 128, AbilityType = AbilityType.Action } },
            { "Eternal Session", new Ability { Name = "Eternal Session", Value = 208, ToggleValue = 128, AbilityType = AbilityType.Action } },
            
            #endregion Action

            #region Support
            
            { "Item Boost", new Ability { Name = "Fire Boost", Value = 155, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "MP Hastega", new Ability { Name = "MP Hastega", Value = 158, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Second Chance", new Ability { Name = "Second Chance", Value = 159, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129, AbilityType = AbilityType.Support } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129, AbilityType = AbilityType.Support } },
            
            #endregion Support
        };
    }
}