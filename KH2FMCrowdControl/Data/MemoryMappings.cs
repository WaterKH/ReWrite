using System.Collections.Generic;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public static class MemoryMappings
    {
        public static Dictionary<string, MemoryObject> Mappings = new Dictionary<string, MemoryObject>
        {
            #region Misc

            { "Munny", new MemoryObject { Name = "Munny", Address = 0x2032DF70, Type = DataType.FourBytes } },

            #endregion Misc

            #region Items



            #endregion Items

            #region Drive Forms

            { "CurrentDrive", new MemoryObject { Name = "Current Drive", Address = 0x21C6C901, Type = DataType.Byte } },
            { "MaxDrive", new MemoryObject { Name = "Max Drive", Address = 0x21C6C902, Type = DataType.Byte } },

            #endregion Drive Forms

            #region Sora Vars
            
            { "CurrentLevel", new MemoryObject { Name = "Current Level", Address = 0x2032E02F, Type = DataType.Byte } },
            { "CurrentExp", new MemoryObject { Name = "Current Experience", Address = 0x2032F210, Type = DataType.FourBytes } },

            { "CurrentHp", new MemoryObject { Name = "Current HP", Address = 0x21C6C750, Type = DataType.FourBytes } },
            { "MaxHp", new MemoryObject { Name = "Max HP", Address = 0x21C6C754, Type = DataType.FourBytes } },

            { "CurrentMp", new MemoryObject { Name = "Current MP", Address = 0x21C6C8D0, Type = DataType.FourBytes } },
            { "MaxMp", new MemoryObject { Name = "Max MP", Address = 0x21C6C8D4, Type = DataType.FourBytes } },
            { "MpRechargeTime", new MemoryObject { Name = "MP Recharge Time", Address = 0x21C6C90C, Type = DataType.Float } },

            #region Stats

            { "CurrentAp", new MemoryObject { Name = "Current AP", Address = 0x21F31A84, Type = DataType.TwoBytes } },
            { "MaxAp", new MemoryObject { Name = "Max AP", Address = 0x21F31A82, Type = DataType.TwoBytes } },

            { "CurrentStrength", new MemoryObject { Name = "Current Strength", Address = 0x21C6C8E0, Type = DataType.TwoBytes } },
            { "StrengthWithEquipment", new MemoryObject { Name = "Strength With Equipment", Address = 0x21C6C8D8, Type = DataType.TwoBytes } },
            { "PowerBoostsUsed", new MemoryObject { Name = "Power Boosts Used", Address = 0x2032E029, Type = DataType.Byte } },

            { "CurrentMagic", new MemoryObject { Name = "Current Magic", Address = 0x21C6C8E2, Type = DataType.TwoBytes } },
            { "MagicWithEquipment", new MemoryObject { Name = "Magic With Equipment", Address = 0x21C6C8DA, Type = DataType.TwoBytes } },
            { "MagicBoostsUsed", new MemoryObject { Name = "Magic Boosts Used", Address = 0x2032E02A, Type = DataType.Byte } },

            { "CurrentDefence", new MemoryObject { Name = "Current Defence", Address = 0x21C6C8E4, Type = DataType.Byte } },
            { "DefenceWithEquipment", new MemoryObject { Name = "Defence With Equipment", Address = 0x21C6C8DC, Type = DataType.TwoBytes } },
            { "DefenceBoostsUsed", new MemoryObject { Name = "Defence Boosts Used", Address = 0x2032E02B, Type = DataType.Byte } },

            #region Equipment

            { "CurrentKeyblade", new MemoryObject { Name = "Current Keyblade", Address = 0x2032E020, Type = DataType.TwoBytes } },
            { "ValorKeyblade", new MemoryObject { Name = "Valor Keyblade", Address = 0x2032EE24, Type = DataType.TwoBytes } },

            #endregion

            #endregion Stats

            #endregion Sora Vars
        };
    }
}