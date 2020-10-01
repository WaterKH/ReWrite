using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {

        #region Equipment

        public async void SendEquipStaffMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Equip Staff", Address = 0x2032E134, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Equipment


        #region Armor

        public async void SendDonaldArmorSlotsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slots", Address = 0x2032E144, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDonaldArmorSlot1Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 1", Address = 0x2032E148, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDonaldArmorSlot2Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 2", Address = 0x2032E14A, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Armor

        #region Accessory

        public async void SendDonaldAccessorySlotsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Accessory Slots", Address = 0x2032E145, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDonaldAccessorySlot1Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 1", Address = 0x2032E158, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDonaldAccessorySlot2Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 2", Address = 0x2032E15A, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDonaldAccessorySlot3Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 3", Address = 0x2032E15C, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Accessory

        #region Items

        public async void SendDonaldItemSlotsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slots", Address = 0x2032E146, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDonaldItemSlot1Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 1", Address = 0x2032E168, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDonaldItemSlot2Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 2", Address = 0x2032E16A, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Items
    }
}