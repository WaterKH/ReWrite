using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {

        #region Misc

        public async void SendMunnyMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Munny", Address = 0x2032DF70, Type = DataType.FourBytes, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Misc
    }
}