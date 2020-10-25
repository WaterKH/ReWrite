using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<KHButtonTemplate>> InitializeSoraModelSwapOptions()
        {
            var options = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Change Sora",
                    Category = GroupType.ModelSwap,
                    Cost = 0,
                    Description = "Choose which Character will replace Sora",
                    ImageUrl = "Characters/Sora.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = Constants.Sora, Cost = Constants.Cost500, Value = 0x54, ManipulationType = ManipulationType.Set, Description = "Revert Sora to KH2 Model", ImageUrl = "Characters/Sora.png" },
                        new KHButtonTemplate { Name = Constants.KH1Sora, Cost = Constants.Cost500, Value = 0x6C1, ManipulationType = ManipulationType.Set, Description = "Switch Model to KH1 Sora", ImageUrl = "Characters/KH1_Sora.png" },
                        new KHButtonTemplate { Name = Constants.CardSora, Cost = Constants.Cost1000, Value = 0x601, ManipulationType = ManipulationType.Set, Description = "Switch Model to Card Sora", ImageUrl = "Characters/Card_Sora.png" },
                        new KHButtonTemplate { Name = Constants.DieSora, Cost = Constants.Cost1000, Value = 0x602, ManipulationType = ManipulationType.Set, Description = "Switch Model to Die Sora", ImageUrl = "Characters/Die_Sora.png" },
                        new KHButtonTemplate { Name = Constants.LionSora, Cost = Constants.Cost750, Value = 0x28A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Lion Sora", ImageUrl = "Characters/Lion_Sora.png" },
                        new KHButtonTemplate { Name = Constants.ChristmasSora, Cost = Constants.Cost500, Value = 0x955, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Sora", ImageUrl = "Characters/Christmas_Sora.png" },
                        new KHButtonTemplate { Name = Constants.Roxas, Cost = Constants.Cost750, Value = 0x5A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Roxas", ImageUrl = "Characters/Roxas.png" },
                        new KHButtonTemplate { Name = Constants.DualwieldRoxas, Cost = Constants.Cost1000, Value = 0x323, ManipulationType = ManipulationType.Set, Description = "Switch Model to Dualwield Roxas", ImageUrl = "Characters/Roxas_Dualwield.png" },
                        new KHButtonTemplate { Name = Constants.MickeyRobed, Cost = Constants.Cost500, Value = 0x5B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Robed Mickey", ImageUrl = "Characters/Mickey_Robed.png" },
                        new KHButtonTemplate { Name = Constants.Mickey, Cost = Constants.Cost500, Value = 0x318, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mickey", ImageUrl = "Characters/Mickey.png" },
                        
                        new KHButtonTemplate { Name = Constants.Donald, Cost = Constants.Cost750, Value = 0x5C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald", ImageUrl = "Characters/Donald.png" },
                        new KHButtonTemplate { Name = Constants.Goofy, Cost = Constants.Cost750, Value = 0x5D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy", ImageUrl = "Characters/Goofy.png" },
                        new KHButtonTemplate { Name = Constants.BirdDonald, Cost = Constants.Cost750, Value = 0x5EF, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald Bird", ImageUrl = "Characters/Bird_Donald.png" },
                        new KHButtonTemplate { Name = Constants.TortoiseGoofy, Cost = Constants.Cost750, Value = 0x61B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy Tortoise", ImageUrl = "Characters/Tortoise_Goofy.png" },
                        new KHButtonTemplate { Name = Constants.Beast, Cost = Constants.Cost750, Value = 0x5E, ManipulationType = ManipulationType.Set, Description = "Switch Model to Beast", ImageUrl = "Characters/Beast.png" },
                        new KHButtonTemplate { Name = Constants.Ping, Cost = Constants.Cost750, Value = 0x64, ManipulationType = ManipulationType.Set, Description = "Switch Model to Ping", ImageUrl = "Characters/Ping.png" },
                        new KHButtonTemplate { Name = Constants.Mulan, Cost = Constants.Cost750, Value = 0x63, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mulan", ImageUrl = "Characters/Mulan.png" },
                        new KHButtonTemplate { Name = Constants.Auron, Cost = Constants.Cost750, Value = 0x65, ManipulationType = ManipulationType.Set, Description = "Switch Model to Auron", ImageUrl = "Characters/Auron.png" },
                        new KHButtonTemplate { Name = Constants.Aladdin, Cost = Constants.Cost750, Value = 0x62, ManipulationType = ManipulationType.Set, Description = "Switch Model to Aladdin", ImageUrl = "Characters/Aladdin.png" },
                        new KHButtonTemplate { Name = Constants.JackSparrow, Cost = Constants.Cost750, Value = 0x66, ManipulationType = ManipulationType.Set, Description = "Switch Model to Captain Jack Sparrow", ImageUrl = "Characters/Jack_Sparrow.png" },
                        new KHButtonTemplate { Name = Constants.HalloweenJack, Cost = Constants.Cost750, Value = 0x5F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Halloween Town Jack", ImageUrl = "Characters/Halloween_Jack.png" },
                        new KHButtonTemplate { Name = Constants.ChristmasJack, Cost = Constants.Cost750, Value = 0x60, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Jack", ImageUrl = "Characters/Christmas_Jack.png" },
                        new KHButtonTemplate { Name = Constants.Simba, Cost = Constants.Cost750, Value = 0x61, ManipulationType = ManipulationType.Set, Description = "Switch Model to Simba", ImageUrl = "Characters/Simba.png" },
                        new KHButtonTemplate { Name = Constants.Tron, Cost = Constants.Cost750, Value = 0x2D4, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Tron.png" },
                        
                        new KHButtonTemplate { Name = Constants.ValorForm, Cost = Constants.Cost2000, Value = 0x55, ManipulationType = ManipulationType.Set, Description = "Equip Sleeping Lion to Sora's Weapon Slot", ImageUrl = "Characters/Valor_Sora.png" },
                        new KHButtonTemplate { Name = Constants.WisdomForm, Cost = Constants.Cost2000, Value = 0x56, ManipulationType = ManipulationType.Set, Description = "Equip Sweet Memories to Sora's Weapon Slot", ImageUrl = "Characters/Wisdom_Sora.png" },
                        new KHButtonTemplate { Name = Constants.LimitForm, Cost = Constants.Cost2000, Value = 0x95D, ManipulationType = ManipulationType.Set, Description = "Equip Mysterious Abyss to Sora's Weapon Slot", ImageUrl = "Characters/Limit_Sora.png" },
                        new KHButtonTemplate { Name = Constants.MasterForm, Cost = Constants.Cost2000, Value = 0x57, ManipulationType = ManipulationType.Set, Description = "Equip Bond of Flame to Sora's Weapon Slot", ImageUrl = "Characters/Master_Sora.png" },
                        new KHButtonTemplate { Name = Constants.FinalForm, Cost = Constants.Cost2000, Value = 0x58, ManipulationType = ManipulationType.Set, Description = "Equip Two Become One to Sora's Weapon Slot", ImageUrl = "Characters/Final_Sora.png" },
                        new KHButtonTemplate { Name = Constants.Antiform, Cost = Constants.Cost3000, Value = 0x59, ManipulationType = ManipulationType.Set, Description = "Equip Fatal Crest to Sora's Weapon Slot", ImageUrl = "Characters/Anti_Sora.png" },
                    }
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Sora")).SubMethodParams.ForEach(x => x.Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendSoraModelMessage));
            
            return options;
        }
    }
}