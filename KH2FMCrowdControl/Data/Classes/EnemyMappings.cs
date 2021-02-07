using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class EnemyMappings
    {
        // Key - Name : Value - Enemy
        public static Dictionary<string, Enemy> Enemies = new Dictionary<string, Enemy>
        {
            #region Land of Dragons

            { "Shan-Yu", new Enemy { Name = "Shan-Yu", Value = 0x15, ValueAddress = 0x21C4BE70, EntitySlot = 4, ImageUrl = "Bosses/Shan-Yu.png" } },
            { "Hayabusa", new Enemy { Name = "Hayabusa", Value = 0x16, ValueAddress = 0x21C4BEB0, EntitySlot = 3, ImageUrl = "Bosses/Hayabusa.png" } },
            { "Riku?", new Enemy { Name = "Riku?", Value = 0x63C, ValueAddress = 0x21C32BB4, EntitySlot = 1, ImageUrl = "Bosses/Riku.png" } },
            { "Storm Rider", new Enemy { Name = "Storm Rider", Value = 0x165, ValueAddress = 0x21C4D324, EntitySlot = 3, ImageUrl = "Bosses/Storm_Rider.png" } },

            #endregion Land of Dragons

            #region Beast's Castle

            { "Thresholder", new Enemy { Name = "Thresholder", Value = 0x161, ValueAddress = 0x21C55204, EntitySlot = 3, ImageUrl = "Bosses/Thresholder.png" } },
            { "Beast", new Enemy { Name = "Beast", Value = 0x2CE, ValueAddress = 0x21C4CBA0, EntitySlot = 3, ImageUrl = "Bosses/Beast.png" } },
            //{ "Shadow Stalker", new Enemy { Name = "Shadow Stalker", Value = 0x163, ValueAddress = 0x21C5A360 } },
            { "Dark Thorn", new Enemy { Name = "Dark Thorn", Value = 0x162, ValueAddress = 0x21C5A4D4, EntitySlot = 3, ImageUrl = "Bosses/Dark_Thorn.png" } },
            { "Xaldin", new Enemy { Name = "Xaldin", Value = 0x3E5, ValueAddress = 0x21C5A0A8, EntitySlot = 3, ImageUrl = "Bosses/Xaldin.png" } },
            { "Marluxia (A. S.)", new Enemy { Name = "Marluxia (A. S.)", Value = 0x923, ValueAddress = 0x21C58FE0, EntitySlot = 3, ImageUrl = "Bosses/Marluxia.png" } },

            #endregion Beast's Castle

            #region Olympus Coliseum

            { "Hades", new Enemy { Name = "Hades", Value = 0x15D, ValueAddress = 0x21C5C0B0, EntitySlot = 3, ImageUrl = "Bosses/Hades.png" } }, // 812 maybe this value?
            { "Cerberus", new Enemy { Name = "Cerberus", Value = 0x15D, ValueAddress = 0x21C4EDF8, EntitySlot = 2, ImageUrl = "Bosses/Cerberus.png" } },
            { "Demyx I", new Enemy { Name = "Demyx", Value = 0x31B, ValueAddress = 0x21C527FC, EntitySlot = 3, ImageUrl = "Bosses/Demyx.png" } },
            { "Pete (1st Battle)", new Enemy { Name = "Pete (1st Battle)", Value = 0x6BB, ValueAddress = 0x21C4F4D0, EntitySlot = 3, ImageUrl = "Bosses/Pete.png" } },
            { "Pete (2nd Battle)", new Enemy { Name = "Pete (2nd Battle)", Value = 0x6BC, ValueAddress = 0x21C4FB08, EntitySlot = 3, ImageUrl = "Bosses/Pete.png" } },
            { "Zexion (A. S.)", new Enemy { Name = "Zexion (A. S.)", Value = 0x97B, ValueAddress = 0x21C597E0, EntitySlot = 3, ImageUrl = "Bosses/Zexion.png" } },

            #endregion Olympus Coliseum

            #region Port Royal

            { "Barbossa", new Enemy { Name = "Barbossa", Value = 0x3F7, ValueAddress = 0x21C43330, EntitySlot = 4, ImageUrl = "Bosses/Barbossa.png" } },
            { "Illuminator", new Enemy { Name = "Illuminator", Value = 0x166, ValueAddress = 0x21C43370, EntitySlot = 3, ImageUrl = "Bosses/Illuminator.png" } },
            { "Grim Reaper", new Enemy { Name = "Grim Reaper", Value = 0x607, ValueAddress = 0x21C5BA78, EntitySlot = 3, ImageUrl = "Bosses/Grim_Reaper.png" } },
            { "Larxene (A. S.)", new Enemy { Name = "Larxene (A. S.)", Value = 0x962, ValueAddress = 0x21C5649C, EntitySlot = 3, ImageUrl = "Bosses/Larxene.png" } },

            #endregion Port Royal

            #region Agrabah

            { "Volcanic Lord", new Enemy { Name = "Volcanic Lord", Value = 0x40B, ValueAddress = 0x21C32934, EntitySlot = 3, ImageUrl = "Bosses/Volcanic_Lord.png" } },
            { "Blizzard Lord", new Enemy { Name = "Blizzard Lord", Value = 0x40C, ValueAddress = 0x21C32974, EntitySlot = 4, ImageUrl = "Bosses/Blizzard_Lord.png" } },
            { "Vexen (A. S.)", new Enemy { Name = "Vexen (A. S.)", Value = 0x933, ValueAddress = 0x21C597A0, EntitySlot = 3, ImageUrl = "Bosses/Vexen.png" } },

            #endregion Agrabah

            #region Halloween/ Christmas Town

            { "Prison Keeper", new Enemy { Name = "Prison Keeper", Value = 0x5CE, ValueAddress = 0x21C55570, EntitySlot = 3, ImageUrl = "Bosses/Prison_Keeper.png" } },
            { "The Experiment", new Enemy { Name = "The Experiment", Value = 0x5D0, ValueAddress = 0x21C56120, EntitySlot = 3, ImageUrl = "Bosses/The_Experiment.png" } },
            
            #endregion Halloween/ Christmas Town

            #region Pride Lands

            { "Scar", new Enemy { Name = "Scar", Value = 0x29C, ValueAddress = 0x21C5A74C, EntitySlot = 3, ImageUrl = "Bosses/Scar.png" } },
            //{ "Groundshaker", new Enemy { Name = "Groundshaker", Value = 0x459, ValueAddress = 0x21C59F80 } },
            
            #endregion Pride Lands

            #region Space Paranoids

            { "Hostile Program", new Enemy { Name = "Hostile Program", Value = 0x4B8, ValueAddress = 0x21C56530, EntitySlot = 3, ImageUrl = "Bosses/Hostile_Program.png" } },
            { "Sark", new Enemy { Name = "Sark", Value = 0x35E, ValueAddress = 0x21C4FCC4, EntitySlot = 3, ImageUrl = "Bosses/Sark.png" } },
            { "Giant Sark", new Enemy { Name = "Giant Sark", Value = 0x3C4, ValueAddress = 0x21C4FFB8, EntitySlot = 3, ImageUrl = "Bosses/Sark.png" } },
            
            #endregion Space Paranoids

            #region Hollow Bastion
            
            { "Demyx II", new Enemy { Name = "Demyx", Value = 0x8F7, ValueAddress = 0x21C4CE7C, EntitySlot = 3, ImageUrl = "Bosses/Demyx.png" } },
            { "Sephiroth", new Enemy { Name = "Sephiroth", Value = 0x8B6, ValueAddress = 0x21C24740, EntitySlot = 1, ImageUrl = "Bosses/Sephiroth.png" } },

            #endregion Hollow Bastion

            #region Data Fights

            { "Xemnas (Data I)", new Enemy { Name = "Xemnas (Data I)", Value = 0x9C9, ValueAddress = 0x21C59BA8, EntitySlot = 1, ImageUrl = "Bosses/Xemnas.png" } },
            { "Xemnas (Data II)", new Enemy { Name = "Xemnas (Data II)", Value = 0x9CA, ValueAddress = 0x21C55AAC, EntitySlot = 2, ImageUrl = "Bosses/Xemnas.png" } },
            { "Xigbar (Data)", new Enemy { Name = "Xigbar (Data)", Value = 0x9C5, ValueAddress = 0x21C4ACBC, EntitySlot = 3, ImageUrl = "Bosses/Xigbar.png" } },
            { "Xaldin (Data)", new Enemy { Name = "Xaldin (Data)", Value = 0x9CB, ValueAddress = 0x21C5A1DC, EntitySlot = 3, ImageUrl = "Bosses/Xaldin.png" } },
            { "Vexen (Data)", new Enemy { Name = "Vexen (Data)", Value = 0x0933, ValueAddress = 0x21C598D4, EntitySlot = 3, ImageUrl = "Bosses/Vexen.png" } },
            { "Lexaeus (Data)", new Enemy { Name = "Lexaeus (Data)", Value = 0x0935, ValueAddress = 0x21C56734, EntitySlot = 3, ImageUrl = "Bosses/Lexaeus.png" } },
            { "Zexion (Data)", new Enemy { Name = "Zexion (Data)", Value = 0x097B, ValueAddress = 0x21C59914, EntitySlot = 3, ImageUrl = "Bosses/Zexion.png" } },
            { "Saix (Data)", new Enemy { Name = "Saix (Data)", Value = 0x9C6, ValueAddress = 0x21C521E0, EntitySlot = 3, ImageUrl = "Bosses/Saix.png" } },
            { "Axel (Data)", new Enemy { Name = "Axel (Data)", Value = 0x9C4, ValueAddress = 0x21C5B0BC, EntitySlot = 3, ImageUrl = "Bosses/Axel.png" } },
            { "Demyx (Data)", new Enemy { Name = "Demyx (Data)", Value = 0x9CC, ValueAddress = 0x21C4D054, EntitySlot = 3, ImageUrl = "Bosses/Demyx.png" } },
            { "Luxord (Data)", new Enemy { Name = "Luxord (Data)", Value = 0x9C8, ValueAddress = 0x21C53700, EntitySlot = 1, ImageUrl = "Bosses/Luxord.png" } },
            { "Marluxia (Data)", new Enemy { Name = "Marluxia (Data)", Value = 0x923, ValueAddress = 0x21C59114, EntitySlot = 3, ImageUrl = "Bosses/Marluxia.png" } },
            { "Larxene (Data)", new Enemy { Name = "Larxene (Data)", Value = 0x962, ValueAddress = 0x21C56868, EntitySlot = 3, ImageUrl = "Bosses/Larxene.png" } },
            { "Roxas (Data)", new Enemy { Name = "Roxas (Data)", Value = 0x951, ValueAddress = 0x21C4F13C, EntitySlot = 1, ImageUrl = "Bosses/Roxas.png" } },

            #endregion Data Fights

            #region Twilight Town

            //{ "Twilight Thorn", new Enemy { Name = "Twilight Thorn", Value = 0x133, ValueAddress =  } },
            //{ "Seifer", new Enemy { Name = "Seifer", Value = 0x678, ValueAddress =  } },
            { "Axel (Struggle Battle)", new Enemy { Name = "Axel (Struggle Battle)", Value = 0x8B5, ValueAddress = 0x21C26ED8, EntitySlot = 1, ImageUrl = "Bosses/Axel.png" } },
            { "Roxas's Shadow", new Enemy { Name = "Roxas's Shadow", Value = 0x754, ValueAddress = 0x21C53F9C, EntitySlot = 1, ImageUrl = "Bosses/Roxas_Shadow.png" } },
            { "Axel (Mansion Battle)", new Enemy { Name = "Axel (Mansion Battle)", Value = 0x51, ValueAddress = 0x21C5AF88, EntitySlot = 1, ImageUrl = "Bosses/Axel.png" } },
            { "Lexaeus (A. S.s)", new Enemy { Name = "Lexaeus (A. S.s)", Value = 0x935, ValueAddress = 0x21C56368, EntitySlot = 3, ImageUrl = "Bosses/Lexaeus.png" } },

            #endregion Twilight Town

            #region Disney Castle

            { "Lingering Will", new Enemy { Name = "Lingering Will", Value = 0x96F, ValueAddress = 0x21C556E0, EntitySlot = 3, ImageUrl = "Bosses/Lingering_Will.png" } },
            
            #endregion Disney Castle

            #region Timeless River

            { "Pete", new Enemy { Name = "Pete", Value = 0x647, ValueAddress = 0x21C55BF0, EntitySlot = 3, ImageUrl = "Bosses/Pete.png" } },

            #endregion Timeless River

            #region The World That Never Was

            { "Roxas", new Enemy { Name = "Roxas", Value = 0x951, ValueAddress = 0x21C4F008, EntitySlot = 1, ImageUrl = "Bosses/Roxas.png" } },
            { "Xigbar", new Enemy { Name = "Xigbar", Value = 0x622, ValueAddress = 0x21C4AB88, EntitySlot = 3, ImageUrl = "Bosses/Xigbar.png" } },
            { "Saix", new Enemy { Name = "Saix", Value = 0x6C9, ValueAddress = 0x21C520AC, EntitySlot = 3, ImageUrl = "Bosses/Saix.png" } },
            { "Luxord", new Enemy { Name = "Luxord", Value = 0x5F8, ValueAddress = 0x21C5358C, EntitySlot = 1, ImageUrl = "Bosses/Luxord.png" } },
            { "Xemnas (Memory Skyscrapper)", new Enemy { Name = "Xemnas (Memory Skyscrapper)", Value = 0x646, ValueAddress = 0x21C5990C, EntitySlot = 1, ImageUrl = "Bosses/Xemnas.png" } },
            //{ "Armored Xemnas", new Enemy { Name = "Armored Xemnas I", Value = 0x85C, ValueAddress = 0x21C5A9AC, EntitySlot = 2, ImageUrl = "" } },
            { "Xemnas (Finale)", new Enemy { Name = "Xemnas (Finale)", Value = 0x81F, ValueAddress = 0x21C5590C, EntitySlot = 2, ImageUrl = "Bosses/Xemnas.png" } },

            #endregion The World That Never Was
        };
    }
}