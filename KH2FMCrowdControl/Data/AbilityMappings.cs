using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class AbilityMappings
    {
        // Key - Name : Value - Ability
        public static Dictionary<string, Ability> SoraAbilities = new Dictionary<string, Ability>
        {
            #region Action 
            
            { "Guard", new Ability { Name = "Guard", Value = 82, ToggleValue = 128 } },
            { "Upper Slash", new Ability { Name = "Upper Slash", Value = 137, ToggleValue = 128 } },
            { "Horizontal Slash", new Ability { Name = "Horizontal Slash", Value = 15, ToggleValue = 129 } },
            { "Finishing Leap", new Ability { Name = "Finishing Leap", Value = 11, ToggleValue = 129 } },
            { "Retaliating Slash", new Ability { Name = "Retaliating Slash", Value = 17, ToggleValue = 129 } },
            { "Slapshot", new Ability { Name = "Slapshot", Value = 6, ToggleValue = 129 } },
            { "Dodge Slash", new Ability { Name = "Dodge Slash", Value = 7, ToggleValue = 129 } },
            { "Flash Step", new Ability { Name = "Flash Step", Value = 47, ToggleValue = 130 } },
            { "Slide Dash", new Ability { Name = "Slide Dash", Value = 8, ToggleValue = 129 } },
            { "Vicinity Break", new Ability { Name = "Vicinity Break", Value = 50, ToggleValue = 130 } },
            { "Guard Break", new Ability { Name = "Guard Break", Value = 9, ToggleValue = 129 } },
            { "Explosion", new Ability { Name = "Explosion", Value = 10, ToggleValue = 129 } },
            { "Aerial Sweep", new Ability { Name = "Aerial Sweep", Value = 13, ToggleValue = 129 } },
            { "Aerial Dive", new Ability { Name = "Aerial Dive", Value = 48, ToggleValue = 130 } },
            { "Aerial Spiral", new Ability { Name = "Aerial Spiral", Value = 14, ToggleValue = 129 } },
            { "Aerial Finish", new Ability { Name = "Aerial Finish", Value = 16, ToggleValue = 129 } },
            { "Magnet Burst", new Ability { Name = "Magnet Burst", Value = 49, ToggleValue = 130 } },
            { "Counterguard", new Ability { Name = "Counterguard", Value = 12, ToggleValue = 129 } },
            { "Auto Valor", new Ability { Name = "Auto Valor", Value = 129, ToggleValue = 129 } },
            { "Auto Wisdom", new Ability { Name = "Auto Wisdom", Value = 130, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 56, ToggleValue = 130 } },
            { "Auto Master", new Ability { Name = "Auto Master", Value = 131, ToggleValue = 129 } },
            { "Auto Final", new Ability { Name = "Auto Final", Value = 132, ToggleValue = 129 } },
            { "Auto Summon", new Ability { Name = "Auto Summon", Value = 133, ToggleValue = 129 } },
            { "Trinity Limit", new Ability { Name = "Trinity Limit", Value = 198, ToggleValue = 128 } },

            #endregion Action

            #region Growth

            { "High Jump LV1", new Ability { Name = "High Jump LV1", Value = 94, ToggleValue = 128 } },
            { "High Jump LV2", new Ability { Name = "High Jump LV2", Value = 95, ToggleValue = 128 } },
            { "High Jump LV3", new Ability { Name = "High Jump LV3", Value = 96, ToggleValue = 128 } },
            { "High Jump MAX", new Ability { Name = "High Jump MAX", Value = 97, ToggleValue = 128 } },

            { "Quick Run LV1", new Ability { Name = "Quick Run LV1", Value = 98, ToggleValue = 128 } },
            { "Quick Run LV2", new Ability { Name = "Quick Run LV2", Value = 99, ToggleValue = 128 } },
            { "Quick Run LV3", new Ability { Name = "Quick Run LV3", Value = 100, ToggleValue = 128 } },
            { "Quick Run MAX", new Ability { Name = "Quick Run MAX", Value = 101, ToggleValue = 128 } },

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
           
            { "Scan", new Ability { Name = "Scan", Value = 138, ToggleValue = 128 } },
            { "Aerial Recovery", new Ability { Name = "Aerial Recovery", Value = 158, ToggleValue = 128 } },
            { "Combo Master", new Ability { Name = "Combo Master", Value = 27, ToggleValue = 130 } },
            { "Combo Plus", new Ability { Name = "Combo Plus", Value = 162, ToggleValue = 128 } },
            { "Air Combo Plus", new Ability { Name = "Air Combo Plus", Value = 163, ToggleValue = 128, MaxNumber = 2 } },
            { "Combo Boost", new Ability { Name = "Combo Boost", Value = 134, ToggleValue = 129 } },
            { "Air Combo Boost", new Ability { Name = "Air Combo Boost", Value = 135, ToggleValue = 129 } },
            { "Reaction Boost", new Ability { Name = "Reaction Boost", Value = 136, ToggleValue = 129, MaxNumber = 2 } },
            { "Finishing Plus", new Ability { Name = "Finishing Plus", Value = 137, ToggleValue = 129, MaxNumber = 2 } },
            { "Negative Combo", new Ability { Name = "Negative Combo", Value = 138, ToggleValue = 129 } },
            { "Berserk Charge", new Ability { Name = "Berserk Charge", Value = 139, ToggleValue = 129 } },
            { "Damage Drive", new Ability { Name = "Damage Drive", Value = 140, ToggleValue = 129 } },
            { "Drive Boost", new Ability { Name = "Drive Boost", Value = 141, ToggleValue = 129 } },
            { "Form Boost", new Ability { Name = "Form Boost", Value = 142, ToggleValue = 129, MaxNumber = 2 } },
            { "Summon Boost", new Ability { Name = "Summon Boost", Value = 143, ToggleValue = 129 } },
            { "Combination Boost", new Ability { Name = "Combination Boost", Value = 144, ToggleValue = 129 } },
            { "Experience Boost", new Ability { Name = "Experience Boost", Value = 145, ToggleValue = 129 } },
            { "Leaf Bracer", new Ability { Name = "Leaf Bracer", Value = 146, ToggleValue = 129 } },
            { "Magic Lock-On", new Ability { Name = "Magic Lock-On", Value = 147, ToggleValue = 129 } },
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129, MaxNumber = 3 } },
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129 } },
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129, MaxNumber = 2 } },
            { "Drive Converter", new Ability { Name = "Drive Converter", Value = 28, ToggleValue = 130 } },
            { "Fire Boost", new Ability { Name = "Fire Boost", Value = 152, ToggleValue = 129 } },
            { "Blizzard Boost", new Ability { Name = "Blizzard Boost", Value = 153, ToggleValue = 129 } },
            { "Thunder Boost", new Ability { Name = "Thunder Boost", Value = 154, ToggleValue = 129 } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129 } },
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129 } },
            { "MP Hastera", new Ability { Name = "MP Hastera", Value = 165, ToggleValue = 129 } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129 } },
            { "Damage Control", new Ability { Name = "Damage Control", Value = 30, ToggleValue = 130 } },
            { "Second Chance", new Ability { Name = "Second Chance", Value = 129, ToggleValue = 129 } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129 } },
            { "No Experience", new Ability { Name = "No Experience", Value = 148, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> DonaldAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Donald Fire", new Ability { Name = "Donald Fire", Value = 165, ToggleValue = 128 } },
            { "Donald Blizzard", new Ability { Name = "Donald Blizzard", Value = 166, ToggleValue = 128 } },
            { "Donald Thunder", new Ability { Name = "Donald Thunder", Value = 167, ToggleValue = 128 } },
            { "Donald Cure", new Ability { Name = "Donald Cure", Value = 168, ToggleValue = 128 } },
            { "Fantasia", new Ability { Name = "Fantasia", Value = 199, ToggleValue = 128 } },
            { "Flare Force", new Ability { Name = "Flare Force", Value = 200, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129 } },
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129 } },
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129 } },
            { "Fire Boost", new Ability { Name = "Fire Boost", Value = 152, ToggleValue = 129 } },
            { "Blizzard Boost", new Ability { Name = "Blizzard Boost", Value = 153, ToggleValue = 129 } },
            { "Thunder Boost", new Ability { Name = "Thunder Boost", Value = 154, ToggleValue = 129 } },
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129 } },
            { "MP Hastera", new Ability { Name = "MP Hastera", Value = 165, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129 } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> GoofyAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Goofy Tornado", new Ability { Name = "Goofy Tornado", Value = 167, ToggleValue = 129 } },
            { "Goofy Bash", new Ability { Name = "Goofy Bash", Value = 173, ToggleValue = 129 } },
            { "Goofy Turbo", new Ability { Name = "Goofy Turbo", Value = 169, ToggleValue = 129 } },
            { "Tornado Fusion", new Ability { Name = "Tornado Fusion", Value = 201, ToggleValue = 128 } },
            { "Teamwork", new Ability { Name = "Teamwork", Value = 202, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129 } },
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129 } },
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129 } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129 } },
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129 } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129 } },
            { "Damage Control", new Ability { Name = "Damage Control", Value = 30, ToggleValue = 130 } },
            { "Second Chance", new Ability { Name = "Second Chance", Value = 159, ToggleValue = 129 } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Auto Change", new Ability { Name = "Auto Change", Value = 162, ToggleValue = 129 } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129 } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> MulanAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Mushu Fire", new Ability { Name = "Mushu Fire", Value = 178, ToggleValue = 129 } },
            { "Flametongue", new Ability { Name = "Flametongue", Value = 179, ToggleValue = 129 } },
            { "Dragonblaze", new Ability { Name = "Dragonblaze", Value = 207, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129 } },
            { "Fire Boost", new Ability { Name = "Fire Boost", Value = 152, ToggleValue = 129 } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> BeastAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Furious Shout", new Ability { Name = "Furious Shout", Value = 177, ToggleValue = 128 } },
            { "Ferocious Rush", new Ability { Name = "Ferocious Rush", Value = 174, ToggleValue = 129 } },
            { "Howling Moon", new Ability { Name = "Howling Moon", Value = 205, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129 } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129 } },
            { "Second Chance", new Ability { Name = "Second Chance", Value = 159, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> AuronAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Divider", new Ability { Name = "Divider", Value = 172, ToggleValue = 129 } },
            { "Healing Water", new Ability { Name = "Healing Water", Value = 176, ToggleValue = 128 } },
            { "Overdrive", new Ability { Name = "Overdrive", Value = 204, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129 } },
            { "MP Haste", new Ability { Name = "MP Haste", Value = 157, ToggleValue = 129 } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> CaptainJackSparrowAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "No Mercy", new Ability { Name = "No Mercy", Value = 190, ToggleValue = 129 } },
            { "Rain Storm", new Ability { Name = "Rain Storm", Value = 191, ToggleValue = 129 } },
            { "Bone Smash", new Ability { Name = "Bone Smash", Value = 192, ToggleValue = 129 } },
            { "Treasure Isle", new Ability { Name = "Treasure Isle", Value = 210, ToggleValue = 128 } },

            #endregion Action

            #region Support
            
            { "Draw", new Ability { Name = "Draw", Value = 149, ToggleValue = 129, MaxNumber = 3 } },
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129 } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129 } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> AladdinAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Slash Frenzy", new Ability { Name = "Slash Frenzy", Value = 170, ToggleValue = 129 } },
            { "Quickplay", new Ability { Name = "Quickplay", Value = 171, ToggleValue = 129 } },
            { "Trick Fantasy", new Ability { Name = "Trick Fantasy", Value = 203, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129 } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129 } },
            { "MP Haste", new Ability { Name = "MP Haste", Value = 157, ToggleValue = 129 } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Auto Change", new Ability { Name = "Auto Change", Value = 162, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> JackSkellingtonAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Blazing Fury", new Ability { Name = "Blazing Fury", Value = 175, ToggleValue = 129 } },
            { "Icy Terror", new Ability { Name = "Icy Terror", Value = 176, ToggleValue = 129 } },
            { "Bolts of Sorrow", new Ability { Name = "Bolts of Sorrow", Value = 177, ToggleValue = 129 } },
            { "Aplause, Aplause", new Ability { Name = "Aplause, Aplause", Value = 206, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "Lucky Lucky", new Ability { Name = "Lucky Lucky", Value = 151, ToggleValue = 129 } },
            { "Fire Boost", new Ability { Name = "Fire Boost", Value = 152, ToggleValue = 129 } },
            { "Blizzard Boost", new Ability { Name = "Blizzard Boost", Value = 153, ToggleValue = 129 } },
            { "Thunder Boost", new Ability { Name = "Thunder Boost", Value = 154, ToggleValue = 129 } },
            { "MP Hastera", new Ability { Name = "MP Hastera", Value = 165, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> SimbaAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Fierce Claw", new Ability { Name = "Fierce Claw", Value = 183, ToggleValue = 129 } },
            { "Groundshaker", new Ability { Name = "Groundshaker", Value = 182, ToggleValue = 129 } },
            { "Healing Herb", new Ability { Name = "Healing Herb", Value = 190, ToggleValue = 128 } },
            { "King's Pride", new Ability { Name = "King's Pride", Value = 209, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "MP Rage", new Ability { Name = "MP Rage", Value = 156, ToggleValue = 129 } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129 } },
            { "Auto Healing", new Ability { Name = "Auto Healing", Value = 164, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> TronAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Scouting Disk", new Ability { Name = "Scouting Disk", Value = 188, ToggleValue = 129 } },
            { "Pulsing Thunder", new Ability { Name = "Pulsing Thunder", Value = 215, ToggleValue = 128 } },
            { "Complete Compilment", new Ability { Name = "Complete Compilment", Value = 211, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "Jackpot", new Ability { Name = "Jackpot", Value = 150, ToggleValue = 129 } },
            { "Thunder Boost", new Ability { Name = "Thunder Boost", Value = 154, ToggleValue = 129 } },
            { "Item Boost", new Ability { Name = "Item Boost", Value = 155, ToggleValue = 129 } },
            { "MP Haste", new Ability { Name = "MP Haste", Value = 157, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Auto Change", new Ability { Name = "Auto Change", Value = 162, ToggleValue = 129 } },
            
            #endregion Support
        };

        public static Dictionary<string, Ability> RikuAbilities = new Dictionary<string, Ability>
        {
            #region Action 

            { "Dark Aura", new Ability { Name = "Dark Aura", Value = 182, ToggleValue = 129 } },
            { "Dark Shield", new Ability { Name = "Dark Shield", Value = 180, ToggleValue = 129 } },
            { "Cure Potion", new Ability { Name = "Cure Potion", Value = 187, ToggleValue = 128 } },
            { "Eternal Session", new Ability { Name = "Eternal Session", Value = 208, ToggleValue = 128 } },
            
            #endregion Action

            #region Support
            
            { "Item Boost", new Ability { Name = "Fire Boost", Value = 155, ToggleValue = 129 } },
            { "MP Hastega", new Ability { Name = "MP Hastega", Value = 158, ToggleValue = 129 } },
            { "Defender", new Ability { Name = "Defender", Value = 158, ToggleValue = 129 } },
            { "Second Chance", new Ability { Name = "Second Chance", Value = 159, ToggleValue = 129 } },
            { "Once More", new Ability { Name = "Once More", Value = 160, ToggleValue = 129 } },
            { "Auto Limit", new Ability { Name = "Auto Limit", Value = 161, ToggleValue = 129 } },
            { "Hyper Healing", new Ability { Name = "Hyper Healing", Value = 163, ToggleValue = 129 } },
            
            #endregion Support
        };
    }
}