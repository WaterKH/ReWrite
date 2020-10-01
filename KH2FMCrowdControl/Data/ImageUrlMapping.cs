using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class ImageUrlMapping
    {
        public Dictionary<string, string> ImageUrlMappings = new Dictionary<string, string>
        {
            #region Misc

            { "Munny", "Munny.png" },

            #endregion Misc

            #region Drive Forms

            // Values for Current Drive
            { "IncreaseDrive", "Increase_Drive.png" }, { "DecreaseDrive", "Decrease_Drive.png" },
            { "FullDrive", "Full_Drive.png" }, { "EmptyDrive", "Empty_Drive.png" },

            // Values for Max Drive Amount
            { "IncreaseMaxDrive", "Increase_Max_Drive.png" }, { "DecreaseMaxDrive", "Decrease_Max_Drive.png" },
            { "FullMaxDrive", "Full_Max_Drive.png" }, { "EmptyMaxDrive", "Empty_Max_Drive.png" },

            { "ChangeForm", "Change_Form.png" },

            // Overlay Values
            { "ValorForm", "Valor_Form_Orb.png" }, { "WisdomForm", "Wisdom_Form_Orb.png" }, { "LimitForm", "Limit_Form_Orb.png" },
            { "MasterForm", "Master_Form_Orb.png" }, { "FinalForm", "Final_Form_Orb.png" }, { "AntiForm", "Anti_Form_Orb.png" },

            #endregion Drive Forms

            #region Sora

            { "IncreaseLevel", "Increase_Level.png" }, { "DecreaseLevel", "Decrease_Level.png" },
            { "MaxLevel", "Max_Level.png" }, { "LevelOne", "Level_One.png" },

            { "IncreaseExp", "Increase_Exp.png" }, { "DecreaseExp", "Decrease_Exp.png" },

            { "MaxHeal", "Max_Heal.png" }, { "Kill", "Kill.png" },
            { "CurrentHpOne", "Current_Hp_One.png" },

            { "MaxFullHp", "Max_Full_Hp.png" }, { "MaxOneHp", "Max_One_Hp.png" },
            { "RevertMaxHp", "Revert_Max_Hp.png" },

            { "MaxMp", "Max_Mp.png" }, { "OneMp", "One_Mp.png" },
            { "ZeroMp", "Zero_Mp.png" },

            { "MaxFullMp", "Max_Full_Mp.png" }, { "MaxOneMp", "Max_One_Mp.png" },
            { "RevertMaxMp", "Revert_Max_Mp.png" },

            #region Stats



            #endregion Stats

            #region Equipment

            { "ChangeKeyblade", "Change_Keyblade.png" }, { "ChangeValorKeyblade", "Change_Valor_Keyblade.pmg" },
            { "ChangeMasterKeyblade", "Change_Master_Keyblade.png" }, { "ChangeFinalKeyblade", "Change_Final_Keyblade.pmg" },

            #endregion Equipment

            #endregion Sora

        };
    }
}