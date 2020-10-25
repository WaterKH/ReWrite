using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {
        #region Stats

        public async void SendSoraLevelMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora's Level", Address = 0x2032E02F, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraCurrentHPMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora's Current HP", Address = 0x21C6C750, Type = DataType.FourBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraMaxHPMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora's Max HP", Address = 0x21C6C754, Type = DataType.FourBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraAPMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora's AP", Address = 0x2032E028, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraStrengthMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora's Strength", Address = 0x2032E029, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora's Magic", Address = 0x2032E02A, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraDefenseMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora's Defense", Address = 0x2032E02B, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Stats

        #region Magic

        public async void SendSoraCurrentMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora Current Magic", Address = 0x21C6C8D0, Type = DataType.FourBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraMaxMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora Max Magic", Address = 0x21C6C8D4, Type = DataType.FourBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraRechargeMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora Recharge Magic", Address = 0x21C6C90C, Type = DataType.Float, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFireMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Fire Magic", Address = 0x2032F0C4, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendBlizzardMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Blizzard Magic", Address = 0x2032F0C5, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendThunderMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Thunder Magic", Address = 0x2032F0C6, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendCureMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Cure Magic", Address = 0x2032F0C7, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMagnetMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Magnet Magic", Address = 0x2032F0FF, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendReflectMagicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Reflect Magic", Address = 0x2032F100, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Magic

        #region Equipment

        public async void SendEquipKeybladeMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Equip Keyblade", Address = 0x2032E020, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendEquipValorKeybladeMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Equip Valor Keyblade", Address = 0x2032EE24, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendEquipMasterKeybladeMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Equip Master Keyblade", Address = 0x2032EECC, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendEquipFinalKeybladeMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Equip Final Keyblade", Address = 0x2032EF04, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Equipment

        #region Armor

        public async void SendSoraArmorSlotsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slots", Address = 0x2032E030, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraArmorSlot1Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 1", Address = 0x2032E034, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraArmorSlot2Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 2", Address = 0x2032E036, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraArmorSlot3Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 3", Address = 0x2032E038, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraArmorSlot4Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 4", Address = 0x2032E03A, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Armor

        #region Accessory

        public async void SendSoraAccessorySlotsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Accessory Slots", Address = 0x2032E031, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraAccessorySlot1Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 1", Address = 0x2032E044, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraAccessorySlot2Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 2", Address = 0x2032E046, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraAccessorySlot3Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 3", Address = 0x2032E048, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraAccessorySlot4Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 4", Address = 0x2032E04A, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Accessory

        #region Items

        public async void SendSoraItemSlotsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slots", Address = 0x2032E032, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraItemSlot1Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 1", Address = 0x2032E054, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraItemSlot2Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 2", Address = 0x2032E056, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraItemSlot3Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 3", Address = 0x2032E058, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraItemSlot4Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 4", Address = 0x2032E05A, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraItemSlot5Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 5", Address = 0x2032E05C, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraItemSlot6Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 6", Address = 0x2032E05E, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraItemSlot7Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 7", Address = 0x2032E060, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoraItemSlot8Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 8", Address = 0x2032E062, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Items

        #region Abilities

        public async void SendSoraActivateAbilityMessage(MemoryParameters memoryParams)
        {
            var ability = (Ability) memoryParams.Value;

            var memoryObject = new MemoryObject { Name = ability.Name, Address = 0x2032E074, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = ability.Value.ToString();

            await this.SendUpdateMemoryRangeMessage(memoryParams.HostName, memoryObject, ability.MaxNumber, ability.ToggleValue);
        }

        public async void SendSoraDeactivateAbilityMessage(MemoryParameters memoryParams)
        {
            var ability = (Ability) memoryParams.Value;

            var memoryObject = new MemoryObject { Name = ability.Name, Address = 0x2032E074, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = ability.Value.ToString();


            await this.SendUpdateMemoryRangeMessage(memoryParams.HostName, memoryObject, ability.MaxNumber, 0);
        }

        #endregion Abilities
    }
}