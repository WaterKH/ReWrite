using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeMiscOptions()
        {
            var items = new List<KHButtonTemplate>() {

                new KHButtonTemplate
                {
                    Name = "Munny",
                    Category = GroupType.Misc,
                    Cost = 0,
                    Description = "Give/ Take Munny",
                    ImageUrl = "Misc/Munny_Pouch.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 50 Munny", Cost = 10, Value = 50, ManipulationType = ManipulationType.Add, Description = "Give Sora 50 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Give 100 Munny", Cost = 20, Value = 100, ManipulationType = ManipulationType.Add, Description = "Give Sora 100 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Give 500 Munny", Cost = 30, Value = 500, ManipulationType = ManipulationType.Add, Description = "Give Sora 500 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Give 1000 Munny", Cost = 40, Value = 1000, ManipulationType = ManipulationType.Add, Description = "Give Sora 1000 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Give 5000 Munny", Cost = 50, Value = 5000, ManipulationType = ManipulationType.Add, Description = "Give Sora 5000 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Give 9999 Munny", Cost = 100, Value = 9999, ManipulationType = ManipulationType.Add, Description = "Give Sora 9999 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Give 99999 Munny", Cost = 500, Value = 99999, ManipulationType = ManipulationType.Add, Description = "Give Sora 99999 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Take 50 Munny", Cost = 10, Value = 50, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 50 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Take 100 Munny", Cost = 20, Value = 100, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 100 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Take 500 Munny", Cost = 30, Value = 500, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 500 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Take 1000 Munny", Cost = 40, Value = 1000, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1000 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Take 5000 Munny", Cost = 50, Value = 5000, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5000 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Take 9999 Munny", Cost = 100, Value = 9999, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 9999 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) },
                            new KHButtonTemplate { Name = "Take 99999 Munny", Cost = 1000, Value = 99999, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99999 Munny", ImageUrl = "Misc/Munny_Pouch.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMunnyMessage) }
                        }
                },
            };

            return items;
        }
    }
}