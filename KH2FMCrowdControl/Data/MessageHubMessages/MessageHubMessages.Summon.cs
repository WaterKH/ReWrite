using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {
        #region Summons

        public async void SendUkuleleBaseballMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Ukulele/ Baseball Charm", Address = 0x2032F1F0, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendLampFeatherMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Lamp/ Feather Charm", Address = 0x2032F1F4, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Summons
    }
}