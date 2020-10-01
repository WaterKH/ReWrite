using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeDriveOptions()
        {
            var items = new List<KHButtonTemplate>() {

                new KHButtonTemplate
                {
                    Name = "Change Gauge",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Give or Take from Sora's Drive Counter",
                    ImageUrl = "Drives/Drive_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Set Drive Counter 0", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Take all of Sora's Drive Counters", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendCurrentDriveCounterMessage) },
                            new KHButtonTemplate { Name = "Set Drive Counter 9", Cost = 450, Value = 9, ManipulationType = ManipulationType.Set, Description = "Give Sora 9 Drive Counters", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendCurrentDriveCounterMessage) },
                            new KHButtonTemplate { Name = "Set Drive Counter Max", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Give Sora 255 Drive Counters", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendCurrentDriveCounterMessage) },
                            new KHButtonTemplate { Name = "Add to Drive Counter", Cost = 450, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 to Sora's Drive Counters", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendCurrentDriveCounterMessage) },
                            new KHButtonTemplate { Name = "Subtract From Drive Counter", Cost = 450, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 from Sora's Drive Counters", ImageUrl = "Drives/Limit_FoDrive_Orbrm_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendCurrentDriveCounterMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Max Gauge",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Give or Take from Sora's Max Drive Counter",
                    ImageUrl = "Drives/Drive_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Set Max Drive Counter 0", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Take all of Sora's Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMaxDriveCounterMessage) },
                            new KHButtonTemplate { Name = "Set Max Drive Counter 9", Cost = 450, Value = 9, ManipulationType = ManipulationType.Set, Description = "Give Sora 9 Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMaxDriveCounterMessage) },
                            new KHButtonTemplate { Name = "Set Max Drive Counter Max", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Give Sora 255 Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMaxDriveCounterMessage) },
                            new KHButtonTemplate { Name = "Add to Max Drive Counter", Cost = 450, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 to Sora's Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMaxDriveCounterMessage) },
                            new KHButtonTemplate { Name = "Subtract From Max Drive Counter", Cost = 450, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 from Sora's Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMaxDriveCounterMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Drive Timer",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Give or Take from Sora's Drive Timer",
                    ImageUrl = "Drives/Drive_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Set Drive Timer 0", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Sets Drive Timer to 0", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveTimeMessage) },
                            new KHButtonTemplate { Name = "Set Drive Timer Max", Cost = 450, Value = 5000, ManipulationType = ManipulationType.Set, Description = "Sets Drive Timer to Current Max", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveTimeMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Enable/ Disable Drive",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Enable or Disable Sora's Drive Forms",
                    ImageUrl = "Drives/Drive_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Disable Drives", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Disable Sora's Drive Forms", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDisableDriveMessage) },
                            new KHButtonTemplate { Name = "Enable Drives", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Enable Sora's Drive Forms", ImageUrl = "Drives/Drive_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDisableDriveMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Give/ Take Drive Form",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Give or Take Sora's Drive Forms",
                    ImageUrl = "Drives/Valor_Form_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give Valor Form", Cost = 450, Value = 2, ManipulationType = ManipulationType.Add, Description = "Give Valor Form to Sora", ImageUrl = "Drives/Valor_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                            new KHButtonTemplate { Name = "Take Valor Form", Cost = 450, Value = 2, ManipulationType = ManipulationType.Subtract, Description = "Take Valor Form from Sora", ImageUrl = "Drives/Valor_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                            new KHButtonTemplate { Name = "Give Wisdom Form", Cost = 450, Value = 4, ManipulationType = ManipulationType.Add, Description = "Give Wisdom Form to Sora", ImageUrl = "Drives/Wisdom_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                            new KHButtonTemplate { Name = "Take Wisdom Form", Cost = 450, Value = 4, ManipulationType = ManipulationType.Subtract, Description = "Take Wisdom Form from Sora", ImageUrl = "Drives/Wisdom_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                            new KHButtonTemplate { Name = "Give Limit Form", Cost = 450, Value = 8, ManipulationType = ManipulationType.Add, Description = "Give Limit Form to Sora", ImageUrl = "Drives/Limit_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendLimitMessage) },
                            new KHButtonTemplate { Name = "Take Limit Form", Cost = 450, Value = 8, ManipulationType = ManipulationType.Subtract, Description = "Take Limit Form from Sora", ImageUrl = "Drives/Limit_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendLimitMessage) },
                            new KHButtonTemplate { Name = "Give Master Form", Cost = 450, Value = 16, ManipulationType = ManipulationType.Add, Description = "Give Master Form to Sora", ImageUrl = "Drives/Master_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                            new KHButtonTemplate { Name = "Take Master Form", Cost = 450, Value = 16, ManipulationType = ManipulationType.Subtract, Description = "Take Master Form from Sora", ImageUrl = "Drives/Master_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                            new KHButtonTemplate { Name = "Give Final Form", Cost = 450, Value = 32, ManipulationType = ManipulationType.Add, Description = "Give Final Form to Sora", ImageUrl = "Drives/Final_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                            new KHButtonTemplate { Name = "Take Final Form", Cost = 450, Value = 32, ManipulationType = ManipulationType.Subtract, Description = "Take Final Form from Sora", ImageUrl = "Drives/Final_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                            new KHButtonTemplate { Name = "Give Anti Form", Cost = 450, Value = 64, ManipulationType = ManipulationType.Add, Description = "Give Anti Form to Sora", ImageUrl = "Drives/Anti_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                            new KHButtonTemplate { Name = "Take Anti Form", Cost = 450, Value = 64, ManipulationType = ManipulationType.Subtract, Description = "Take Anti Form from Sora", ImageUrl = "Drives/Anti_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendValorWisdomMasterFinalAntiMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Activate Drive",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Activate Drive",
                    ImageUrl = "Drives/Valor_Form_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Normal", Cost = 600, Value = 0, ManipulationType = ManipulationType.Set, Description = "Revert Sora Back to Normal", ImageUrl = "Drives/Normal_Form.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendActivateFormMessage) },
                            new KHButtonTemplate { Name = "Valor Form", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Activate Valor Form", ImageUrl = "Drives/Valor_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendActivateFormMessage) },
                            new KHButtonTemplate { Name = "Wisdom Form", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Activate Wisdom Form", ImageUrl = "Drives/Wisdom_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendActivateFormMessage) },
                            new KHButtonTemplate { Name = "Limit Form", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Activate Limit Form", ImageUrl = "Drives/Limit_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendActivateFormMessage) },
                            new KHButtonTemplate { Name = "Master Form", Cost = 800, Value = 4, ManipulationType = ManipulationType.Set, Description = "Activate Master Form", ImageUrl = "Drives/Master_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendActivateFormMessage) },
                            new KHButtonTemplate { Name = "Final Form", Cost = 1000, Value = 5, ManipulationType = ManipulationType.Set, Description = "Activate Final Form", ImageUrl = "Drives/Final_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendActivateFormMessage) },
                            new KHButtonTemplate { Name = "Antiform", Cost = 1000, Value = 6, ManipulationType = ManipulationType.Set, Description = "Activate Antiform", ImageUrl = "Drives/Anti_Form_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendActivateFormMessage) },
                            new KHButtonTemplate { Name = "Mickey?", Cost = 1000, Value = 7, ManipulationType = ManipulationType.Set, Description = "Activate Mickey?", ImageUrl = "Drives/Mickey_Form.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendActivateFormMessage) },
                        }
                },
            };


            return items;
        }
    }
}