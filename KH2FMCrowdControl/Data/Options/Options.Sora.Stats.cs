using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSoraStatsOptions()
        {
            var options = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Change Level",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Current Level",
                    ImageUrl = "Level/Normal.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = "Level Zero", Cost = Constants.Cost2000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Level to 0", ImageUrl = "Level/Sad.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
                        new KHButtonTemplate { Name = "Level One", Cost = Constants.Cost1000, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Level to 1", ImageUrl = "Level/Hurt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
                        new KHButtonTemplate { Name = "Level 99", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Level to 99", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
                        new KHButtonTemplate { Name = "Add Level", Cost = Constants.Cost500, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's Current Level", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
                        new KHButtonTemplate { Name = "Subtract Level", Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's Current Level", ImageUrl = "Level/Hurt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraLevelMessage) },
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
                        // TODO Calculate our max HP and give max/ half of that
                        new KHButtonTemplate { Name = "No HP", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to Zero", ImageUrl = "Level/Sad.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentHPMessage) },
                        new KHButtonTemplate { Name = "One HP", Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to One", ImageUrl = "Level/Sad.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentHPMessage) },
                        new KHButtonTemplate { Name = "Half HP", Cost = Constants.Cost500, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to Half", ImageUrl = "Level/Hurt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentHPMessage) },
                        new KHButtonTemplate { Name = "Max HP", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to Max", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraCurrentHPMessage) },
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
                        new KHButtonTemplate { Name = "Invulnerability", Cost = Constants.Cost2000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to Zero - Grants Invulnerability", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxHPMessage) },
                        new KHButtonTemplate { Name = "One Max HP", Cost = Constants.Cost2000, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to One", ImageUrl = "Level/Sad.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxHPMessage) },
                        new KHButtonTemplate { Name = "Half Max HP", Cost = Constants.Cost500, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to Half", ImageUrl = "Level/Hurt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxHPMessage) },
                        new KHButtonTemplate { Name = "Max Max HP", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to Max", ImageUrl = "Level/Normal.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMaxHPMessage) },
                    }
                },
                new KHButtonTemplate
                {
                    Name = "Change AP",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's AP Boosts",
                    ImageUrl = "Items/AP_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = "AP Boosts Zero", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's AP to 0", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAPMessage) },
                        new KHButtonTemplate { Name = "Max AP Boosts", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's AP to Max", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAPMessage) },
                        new KHButtonTemplate { Name = "Add AP Boosts", Cost = Constants.Cost500, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's AP", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAPMessage) },
                        new KHButtonTemplate { Name = "Subtract AP Boosts", Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's AP", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraAPMessage) },
                    }
                },
                new KHButtonTemplate
                {
                    Name = "Change Strength Stat",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Strength Boosts",
                    ImageUrl = "Items/Power_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Strength Boosts Zero", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Strength to 0", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraStrengthMessage) },
                            new KHButtonTemplate { Name = "Max Strength Boosts", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Strength to Max", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraStrengthMessage) },
                            new KHButtonTemplate { Name = "Add Strength Boosts", Cost = Constants.Cost500, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's Strength", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraStrengthMessage) },
                            new KHButtonTemplate { Name = "Subtract Strength Boosts", Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's Strength", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraStrengthMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Magic Stat",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Magic Boosts",
                    ImageUrl = "Items/Magic_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Magic Boosts Zero", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic to 0", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMagicMessage) },
                            new KHButtonTemplate { Name = "Max Magic Boosts", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic to Max", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMagicMessage) },
                            new KHButtonTemplate { Name = "Add Magic Boosts", Cost = Constants.Cost500, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's Magic", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMagicMessage) },
                            new KHButtonTemplate { Name = "Subtract Magic Boosts", Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's Magic", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraMagicMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = "Change Defense Stat",
                    Category = GroupType.Sora,
                    Cost = 0,
                    Description = "Update Sora's Defense Boosts",
                    ImageUrl = "Items/Defense_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Defense Boosts Zero", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Defense to 0", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraDefenseMessage) },
                            new KHButtonTemplate { Name = "Max Defense Boosts", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Defense to Max", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraDefenseMessage) },
                            new KHButtonTemplate { Name = "Add Defense Boosts", Cost = Constants.Cost500, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 level to Sora's Defense", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraDefenseMessage) },
                            new KHButtonTemplate { Name = "Subtract Defense Boosts", Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 level to Sora's Defense", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraDefenseMessage) },
                        }
                }
            };

            return options;
        }
    }
}