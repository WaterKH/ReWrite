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
            this.SendDriveTimeMessage(new MemoryParameters { HostName = memoryParams.HostName, ManipulationType = ManipulationType.Set, Value = 0 });

            System.Threading.Thread.Sleep(1000);

            var memoryObjects = new MemoryObject[] 
            { 
                new MemoryObject { Name = "Display Popup", Address = 0x21C5FF48, Type = DataType.TwoBytes, ManipulationType = ManipulationType.Set, Value = "0" },
                new MemoryObject { Name = "Set Reaction Command Option", Address = 0x21C5FF4E, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType , Value = memoryParams.Value.ToString() },
                new MemoryObject { Name = "Enable Popup", Address = 0x21C5FF51, Type = DataType.Byte, ManipulationType = ManipulationType.Set, Value = "0" },
                //new MemoryObject { Name = "Enable Popup", Address = 0x21C5FF53, Type = DataType.Byte, ManipulationType = ManipulationType.Set, Value = "1" },
                new MemoryObject { Name = "Press Triangle Reaction Command", Address = 0x2034D45D, Type = DataType.Byte, ManipulationType = ManipulationType.Set, Value = ButtonMappings.Button["Triangle"] },
            };
            
            await this.SendUpdateMultipleMemoryMessage(memoryParams.HostName, memoryObjects);
        }

        #endregion Drive
    }
}