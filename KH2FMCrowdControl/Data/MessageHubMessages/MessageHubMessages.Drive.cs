using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {
        #region Drive

        public async void SendCurrentDriveCounterMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Current Drive Counter", Address = 0x21C6C901, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMaxDriveCounterMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Max Drive Counter", Address = 0x21C6C902, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDriveTimeMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Drive Time", Address = 0x21C6C904, Type = DataType.Float, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDisableDriveMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Disable Drive", Address = 0x20351EB8, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendValorWisdomMasterFinalAntiMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Valor/ Wisdom/ Master/ Final/ Anti Form", Address = 0x2032F1F0, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendLimitMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Limit Form", Address = 0x2032F1FA, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendActivateFormMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Activate Form", Address = 0x2032F054, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Drive
    }
}