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
        public async Task<List<KHButtonTemplate>> InitializeSoraStatsOptions()
        {
            var items = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Change Level",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Current Level",
                    ImageUrl = "Level/Normal.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Level Zero", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Level to 0", ImageUrl = "Level/Sad.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
                            new KHButtonTemplate { Name = "Level One", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Level to 1", ImageUrl = "Level/Hurt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
                            new KHButtonTemplate { Name = "Level 99", Cost = 450, Value = 99, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Level to 99", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
                            new KHButtonTemplate { Name = "Add Level", Cost = 450, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's Current Level", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
                            new KHButtonTemplate { Name = "Subtract Level", Cost = 450, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's Current Level", ImageUrl = "Level/Hurt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change HP",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Current HP",
                    ImageUrl = "Level/Normal.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "No HP", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to Zero", ImageUrl = "Level/Sad.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentHPMessage) },
                            new KHButtonTemplate { Name = "One HP", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to One", ImageUrl = "Level/Sad.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentHPMessage) },
                            new KHButtonTemplate { Name = "Half HP", Cost = 450, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to Half", ImageUrl = "Level/Hurt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentHPMessage) },
                            new KHButtonTemplate { Name = "Max HP", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to Max", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentHPMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Max HP",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Max HP",
                    ImageUrl = "Level/Normal.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Invulnerability", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to Zero - Grants Invulnerability", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxHPMessage) },
                            new KHButtonTemplate { Name = "One Max HP", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to One", ImageUrl = "Level/Sad.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxHPMessage) },
                            new KHButtonTemplate { Name = "Half Max HP", Cost = 450, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to Half", ImageUrl = "Level/Hurt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxHPMessage) },
                            new KHButtonTemplate { Name = "Max Max HP", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to Max", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxHPMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change AP",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's AP",
                    ImageUrl = "Items/AP_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "AP Zero", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's AP to 0", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAPMessage) },
                            new KHButtonTemplate { Name = "Max AP", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's AP to Max", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAPMessage) },
                            new KHButtonTemplate { Name = "Add AP", Cost = 450, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's AP", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAPMessage) },
                            new KHButtonTemplate { Name = "Subtract AP", Cost = 450, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's AP", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAPMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Strength Stat",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's AP",
                    ImageUrl = "Items/Power_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Strength Zero", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Strength to 0", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraStrengthMessage) },
                            new KHButtonTemplate { Name = "Max Strength", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Strength to Max", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraStrengthMessage) },
                            new KHButtonTemplate { Name = "Add Strength", Cost = 450, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's Strength", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraStrengthMessage) },
                            new KHButtonTemplate { Name = "Subtract Strength", Cost = 450, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's Strength", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraStrengthMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Magic Stat",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Magic",
                    ImageUrl = "Items/Magic_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Magic Zero", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic to 0", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMagicMessage) },
                            new KHButtonTemplate { Name = "Max Magic", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic to Max", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMagicMessage) },
                            new KHButtonTemplate { Name = "Add Magic", Cost = 450, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's Magic", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMagicMessage) },
                            new KHButtonTemplate { Name = "Subtract Magic", Cost = 450, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's Magic", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Defense Stat",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Defense",
                    ImageUrl = "Items/Defense_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Defense Zero", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Defense to 0", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraDefenseMessage) },
                            new KHButtonTemplate { Name = "Max Defense", Cost = 450, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Defense to Max", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraDefenseMessage) },
                            new KHButtonTemplate { Name = "Add Defense", Cost = 450, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's Defense", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraDefenseMessage) },
                            new KHButtonTemplate { Name = "Subtract Defense", Cost = 450, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's Defense", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraDefenseMessage) },
                        }
                }
            };

            return items;
        }
    }
}