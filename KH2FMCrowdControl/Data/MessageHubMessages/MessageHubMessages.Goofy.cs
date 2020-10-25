using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {
        #region Equipment

        public async void SendEquipShieldMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Equip Shield", Address = 0x2032E248, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Equipment

        #region Armor

        public async void SendGoofyArmorSlotsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slots", Address = 0x2032E258, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoofyArmorSlot1Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 1", Address = 0x2032E25C, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoofyArmorSlot2Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 2", Address = 0x2032E25E, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoofyArmorSlot3Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Armor Slot 3", Address = 0x2032E260, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Armor

        #region Accessory

        public async void SendGoofyAccessorySlotsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Accessory Slots", Address = 0x2032E259, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoofyAccessorySlot1Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Accessory Slot 1", Address = 0x2032E26C, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoofyAccessorySlot2Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Accessory Slot 2", Address = 0x2032E26E, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Accessory

        #region Items

        public async void SendGoofyItemSlotsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slots", Address = 0x2032E25A, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoofyItemSlot1Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 1", Address = 0x2032E27C, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoofyItemSlot2Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 2", Address = 0x2032E27E, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoofyItemSlot3Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 3", Address = 0x2032E280, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoofyItemSlot4Message(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Item Slot 4", Address = 0x2032E282, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Items
    }
}