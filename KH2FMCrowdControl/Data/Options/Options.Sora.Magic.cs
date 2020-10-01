using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSoraMagicOptions()
        {
            var items = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Change Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Current Magic",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "No Magic", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Magic to Zero", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentMagicMessage) },
                            new KHButtonTemplate { Name = "One Magic", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Magic to One", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentMagicMessage) },
                            new KHButtonTemplate { Name = "Half Magic", Cost = 450, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Magic to Half", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentMagicMessage) },
                            new KHButtonTemplate { Name = "Max Magic", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Magic to Max", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Max Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Max Magic",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "No Magic", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max Magic to Zero", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxMagicMessage) },
                            new KHButtonTemplate { Name = "One Max Magic", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max Magic to One", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxMagicMessage) },
                            new KHButtonTemplate { Name = "Half Max Magic", Cost = 450, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max Magic to Half", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxMagicMessage) },
                            new KHButtonTemplate { Name = "Max Max Magic", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max Magic to Max", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Recharge Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "(Note: May only work when currently out of magic)",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Instant Refill", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Restore Sora's Magic Bar", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraRechargeMagicMessage) },
                            new KHButtonTemplate { Name = "Max out Timer", Cost = 450, Value = 3000, ManipulationType = ManipulationType.Set, Description = "Fill the Timer Back To Full", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraRechargeMagicMessage) },
                            new KHButtonTemplate { Name = "Fill Half", Cost = 450, Value = 1500, ManipulationType = ManipulationType.Set, Description = "Fill the Timer to Half-way", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraRechargeMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Give/ Take Fire Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Give Fire/ Fira/ Firaga or Remove",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Take Fire", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Fire Element from Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendFireMagicMessage) },
                            new KHButtonTemplate { Name = "Give Fire", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Fire to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendFireMagicMessage) },
                            new KHButtonTemplate { Name = "Give Fira", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Fira to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendFireMagicMessage) },
                            new KHButtonTemplate { Name = "Give Firaga", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Firaga to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendFireMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Give/ Take Blizzard Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Give Blizzard/ Blizzara/ Blizzaga or Remove",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Take Blizzard", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Blizzard Element from Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendBlizzardMagicMessage) },
                            new KHButtonTemplate { Name = "Give Blizzard", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Blizzard to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendBlizzardMagicMessage) },
                            new KHButtonTemplate { Name = "Give Blizzara", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Blizzara to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendBlizzardMagicMessage) },
                            new KHButtonTemplate { Name = "Give Blizzaga", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Blizzaga to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendBlizzardMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Give/ Take Thunder Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Give Thunder/ Thundara/ Thundaga or Remove",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Take Thunder", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Thunder Element from Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendThunderMagicMessage) },
                            new KHButtonTemplate { Name = "Give Thunder", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Thunder to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendThunderMagicMessage) },
                            new KHButtonTemplate { Name = "Give Thundara", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Thundara to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendThunderMagicMessage) },
                            new KHButtonTemplate { Name = "Give Thundaga", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Thundaga to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendThunderMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Give/ Take Thunder Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Give Thunder/ Thundara/ Thundaga or Remove",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Take Thunder", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Thunder Element from Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendThunderMagicMessage) },
                            new KHButtonTemplate { Name = "Give Thunder", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Thunder to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendThunderMagicMessage) },
                            new KHButtonTemplate { Name = "Give Thundara", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Thundara to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendThunderMagicMessage) },
                            new KHButtonTemplate { Name = "Give Thundaga", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Thundaga to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendThunderMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Give/ Take Cure Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Give Cure/ Cura/ Curaga or Remove",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Take Cure", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Cure Element from Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendCureMagicMessage) },
                            new KHButtonTemplate { Name = "Give Cure", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Cure to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendCureMagicMessage) },
                            new KHButtonTemplate { Name = "Give Cura", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Cura to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendCureMagicMessage) },
                            new KHButtonTemplate { Name = "Give Curaga", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Curaga to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendCureMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Give/ Take Magnet Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Give Magnet/ Magnera/ Magnega or Remove",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Take Magnet", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Magnet Element from Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagnetMagicMessage) },
                            new KHButtonTemplate { Name = "Give Magnet", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Magnet to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagnetMagicMessage) },
                            new KHButtonTemplate { Name = "Give Magnera", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Magnera to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagnetMagicMessage) },
                            new KHButtonTemplate { Name = "Give Magnega", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Magnega to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagnetMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Give/ Take Reflect Magic",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Give Reflect/ Reflera/ Reflega or Remove",
                    ImageUrl = "Magic/Spell_Orb.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Take Reflect", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Reflect Element from Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendReflectMagicMessage) },
                            new KHButtonTemplate { Name = "Give Reflect", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Reflect to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendReflectMagicMessage) },
                            new KHButtonTemplate { Name = "Give Reflera", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Reflera to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendReflectMagicMessage) },
                            new KHButtonTemplate { Name = "Give Reflega", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Reflega to Sora's Magic", ImageUrl = "Magic/Spell_Orb.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendReflectMagicMessage) },
                        }
                }
            };

            return items;
        }
    }
}