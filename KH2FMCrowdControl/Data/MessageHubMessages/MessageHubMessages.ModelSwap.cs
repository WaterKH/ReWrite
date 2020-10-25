using System;
using System.Security.Cryptography.X509Certificates;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {
        public async void SendSoraModelMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sora Model Swap", Address = 0x21CE0B68, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDonaldAllyModelMessage(MemoryParameters memoryParams)
        {
            var memoryObjects = new MemoryObject[]
            {
                new MemoryObject { Name = "Donald (Ally) Model Swap", Address = 0x21CE0B6A, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType, Value = memoryParams.Value.ToString() },
                new MemoryObject { Name = "Set Ally", Address = 0x2036C3E8, Type = DataType.FourBytes, ManipulationType = memoryParams.ManipulationType, Value = "1503732" }
            };
            
            await this.SendUpdateMultipleMemoryMessage(memoryParams.HostName, memoryObjects);
        }

        public async void SendDonaldEnemyModelMessage(MemoryParameters memoryParams)
        {
            var memoryObjects = new MemoryObject[]
            {
                new MemoryObject { Name = "Donald (Enemy) Model Swap", Address = 0x21CE0B6A, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType, Value = memoryParams.Value.ToString() },
                new MemoryObject { Name = "Set Enemy", Address = 0x2036C3E8, Type = DataType.FourBytes, ManipulationType = memoryParams.ManipulationType, Value = "1503612" }
            };

            await this.SendUpdateMultipleMemoryMessage(memoryParams.HostName, memoryObjects);
        }

        public async void SendGoofyAllyModelMessage(MemoryParameters memoryParams)
        {
            var memoryObjects = new MemoryObject[]
            {
                new MemoryObject { Name = "Goofy (Ally) Model Swap", Address = 0x21CE0B6C, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType, Value = memoryParams.Value.ToString() },
                new MemoryObject { Name = "Set Ally", Address = 0x2036C3E8, Type = DataType.FourBytes, ManipulationType = memoryParams.ManipulationType, Value = "1503732" }
            };

            await this.SendUpdateMultipleMemoryMessage(memoryParams.HostName, memoryObjects);
        }

        public async void SendGoofyEnemyModelMessage(MemoryParameters memoryParams)
        {
            var memoryObjects = new MemoryObject[]
            {
                new MemoryObject { Name = "Goofy (Enemy) Model Swap", Address = 0x21CE0B6C, Type = DataType.TwoBytes, ManipulationType = memoryParams.ManipulationType, Value = memoryParams.Value.ToString() },
                new MemoryObject { Name = "Set Enemy", Address = 0x2036C3E8, Type = DataType.FourBytes, ManipulationType = memoryParams.ManipulationType, Value = "1503612" }
            };

            await this.SendUpdateMultipleMemoryMessage(memoryParams.HostName, memoryObjects);
        }
    }
}
