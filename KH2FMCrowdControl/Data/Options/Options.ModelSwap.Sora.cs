using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSoraModelSwapOptions()
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Sora",
                    Category = GroupType.ModelSwap,
                    Cost = 0,
                    Description = "Choose which Character will replace Sora",
                    ImageUrl = "Characters/Sora.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = Constants.Sora, Cost = Constants.Cost500, Value = 0x54, ManipulationType = ManipulationType.Set, Description = "Revert Sora to KH2 Model", ImageUrl = "Characters/Sora.png" },
                        new ButtonTemplate { Name = Constants.KH1Sora, Cost = Constants.Cost500, Value = 0x6C1, ManipulationType = ManipulationType.Set, Description = "Switch Model to KH1 Sora", ImageUrl = "Characters/KH1_Sora.png" },
                        new ButtonTemplate { Name = Constants.CardSora, Cost = Constants.Cost1000, Value = 0x601, ManipulationType = ManipulationType.Set, Description = "Switch Model to Card Sora", ImageUrl = "Characters/Card_Sora.png" },
                        new ButtonTemplate { Name = Constants.DieSora, Cost = Constants.Cost1000, Value = 0x602, ManipulationType = ManipulationType.Set, Description = "Switch Model to Die Sora", ImageUrl = "Characters/Die_Sora.png" },
                        new ButtonTemplate { Name = Constants.LionSora, Cost = Constants.Cost750, Value = 0x28A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Lion Sora", ImageUrl = "Characters/Lion_Sora.png" },
                        //new ButtonTemplate { Name = Constants.ChristmasSora, Cost = Constants.Cost500, Value = 0x955, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Sora", ImageUrl = "Characters/Christmas_Sora.png" },
                        new ButtonTemplate { Name = Constants.Roxas, Cost = Constants.Cost750, Value = 0x5A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Roxas", ImageUrl = "Characters/Roxas.png" },
                        new ButtonTemplate { Name = Constants.DualwieldRoxas, Cost = Constants.Cost1000, Value = 0x323, ManipulationType = ManipulationType.Set, Description = "Switch Model to Dualwield Roxas", ImageUrl = "Characters/Roxas_Dualwield.png" },
                        new ButtonTemplate { Name = Constants.MickeyRobed, Cost = Constants.Cost500, Value = 0x5B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Robed Mickey", ImageUrl = "Characters/Mickey_Robed.png" },
                        new ButtonTemplate { Name = Constants.Mickey, Cost = Constants.Cost500, Value = 0x318, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mickey", ImageUrl = "Characters/Mickey.png" },

                        new ButtonTemplate { Name = Constants.Donald, Cost = Constants.Cost750, Value = 0x5C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald", ImageUrl = "Characters/Donald.png" },
                        new ButtonTemplate { Name = Constants.Goofy, Cost = Constants.Cost750, Value = 0x5D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy", ImageUrl = "Characters/Goofy.png" },
                        new ButtonTemplate { Name = Constants.BirdDonald, Cost = Constants.Cost750, Value = 0x5EF, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald Bird", ImageUrl = "Characters/Bird_Donald.png" },
                        new ButtonTemplate { Name = Constants.TortoiseGoofy, Cost = Constants.Cost750, Value = 0x61B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy Tortoise", ImageUrl = "Characters/Tortoise_Goofy.png" },
                        //new ButtonTemplate { Name = Constants.Beast, Cost = Constants.Cost750, Value = 0x5E, ManipulationType = ManipulationType.Set, Description = "Switch Model to Beast", ImageUrl = "Characters/Beast.png" },
                        new ButtonTemplate { Name = Constants.Ping, Cost = Constants.Cost750, Value = 0x64, ManipulationType = ManipulationType.Set, Description = "Switch Model to Ping", ImageUrl = "Characters/Ping.png" },
                        new ButtonTemplate { Name = Constants.Mulan, Cost = Constants.Cost750, Value = 0x63, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mulan", ImageUrl = "Characters/Mulan.png" },
                        new ButtonTemplate { Name = Constants.Auron, Cost = Constants.Cost750, Value = 0x65, ManipulationType = ManipulationType.Set, Description = "Switch Model to Auron", ImageUrl = "Characters/Auron.png" },
                        new ButtonTemplate { Name = Constants.Aladdin, Cost = Constants.Cost750, Value = 0x62, ManipulationType = ManipulationType.Set, Description = "Switch Model to Aladdin", ImageUrl = "Characters/Aladdin.png" },
                        new ButtonTemplate { Name = Constants.JackSparrow, Cost = Constants.Cost750, Value = 0x66, ManipulationType = ManipulationType.Set, Description = "Switch Model to Captain Jack Sparrow", ImageUrl = "Characters/Jack_Sparrow.png" },
                        new ButtonTemplate { Name = Constants.HalloweenJack, Cost = Constants.Cost750, Value = 0x5F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Halloween Town Jack", ImageUrl = "Characters/Halloween_Jack.png" },
                        new ButtonTemplate { Name = Constants.ChristmasJack, Cost = Constants.Cost750, Value = 0x60, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Jack", ImageUrl = "Characters/Christmas_Jack.png" },
                        new ButtonTemplate { Name = Constants.Simba, Cost = Constants.Cost750, Value = 0x61, ManipulationType = ManipulationType.Set, Description = "Switch Model to Simba", ImageUrl = "Characters/Simba.png" },
                        new ButtonTemplate { Name = Constants.Tron, Cost = Constants.Cost750, Value = 0x2D4, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Tron.png" },

                        new ButtonTemplate { Name = Constants.ValorForm, Cost = Constants.Cost2000, Value = 0x55, ManipulationType = ManipulationType.Set, Description = "Switch Model to Valor Form", ImageUrl = "Characters/Valor_Sora.png" },
                        new ButtonTemplate { Name = Constants.WisdomForm, Cost = Constants.Cost2000, Value = 0x56, ManipulationType = ManipulationType.Set, Description = "Switch Model to Wisdom Form", ImageUrl = "Characters/Wisdom_Sora.png" },
                        new ButtonTemplate { Name = Constants.LimitForm, Cost = Constants.Cost2000, Value = 0x95D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Limit Form", ImageUrl = "Characters/Limit_Sora.png" },
                        new ButtonTemplate { Name = Constants.MasterForm, Cost = Constants.Cost2000, Value = 0x57, ManipulationType = ManipulationType.Set, Description = "Switch Model to Master Form", ImageUrl = "Characters/Master_Sora.png" },
                        new ButtonTemplate { Name = Constants.FinalForm, Cost = Constants.Cost2000, Value = 0x58, ManipulationType = ManipulationType.Set, Description = "Switch Model to Final Form", ImageUrl = "Characters/Final_Sora.png" },
                        new ButtonTemplate { Name = Constants.Antiform, Cost = Constants.Cost3000, Value = 0x59, ManipulationType = ManipulationType.Set, Description = "Switch Model to Anti Form", ImageUrl = "Characters/Anti_Sora.png" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Lion Sora",
                    Category = GroupType.ModelSwap,
                    Cost = 0,
                    Description = "Choose which Character will replace Lion Sora",
                    ImageUrl = "Characters/Lion_Sora.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = Constants.LionSora, Cost = Constants.Cost750, Value = 0x28A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Lion Sora", ImageUrl = "Characters/Lion_Sora.png" },

                        new ButtonTemplate { Name = Constants.Sora, Cost = Constants.Cost500, Value = 0x54, ManipulationType = ManipulationType.Set, Description = "Revert Sora to KH2 Model", ImageUrl = "Characters/Sora.png" },
                        new ButtonTemplate { Name = Constants.KH1Sora, Cost = Constants.Cost500, Value = 0x6C1, ManipulationType = ManipulationType.Set, Description = "Switch Model to KH1 Sora", ImageUrl = "Characters/KH1_Sora.png" },
                        new ButtonTemplate { Name = Constants.CardSora, Cost = Constants.Cost1000, Value = 0x601, ManipulationType = ManipulationType.Set, Description = "Switch Model to Card Sora", ImageUrl = "Characters/Card_Sora.png" },
                        new ButtonTemplate { Name = Constants.DieSora, Cost = Constants.Cost1000, Value = 0x602, ManipulationType = ManipulationType.Set, Description = "Switch Model to Die Sora", ImageUrl = "Characters/Die_Sora.png" },
                        new ButtonTemplate { Name = Constants.Roxas, Cost = Constants.Cost750, Value = 0x5A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Roxas", ImageUrl = "Characters/Roxas.png" },
                        new ButtonTemplate { Name = Constants.DualwieldRoxas, Cost = Constants.Cost1000, Value = 0x323, ManipulationType = ManipulationType.Set, Description = "Switch Model to Dualwield Roxas", ImageUrl = "Characters/Roxas_Dualwield.png" },
                        new ButtonTemplate { Name = Constants.MickeyRobed, Cost = Constants.Cost500, Value = 0x5B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Robed Mickey", ImageUrl = "Characters/Mickey_Robed.png" },
                        new ButtonTemplate { Name = Constants.Mickey, Cost = Constants.Cost500, Value = 0x318, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mickey", ImageUrl = "Characters/Mickey.png" },

                        new ButtonTemplate { Name = Constants.Donald, Cost = Constants.Cost750, Value = 0x5C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald", ImageUrl = "Characters/Donald.png" },
                        new ButtonTemplate { Name = Constants.Goofy, Cost = Constants.Cost750, Value = 0x5D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy", ImageUrl = "Characters/Goofy.png" },
                        new ButtonTemplate { Name = Constants.BirdDonald, Cost = Constants.Cost750, Value = 0x5EF, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald Bird", ImageUrl = "Characters/Bird_Donald.png" },
                        new ButtonTemplate { Name = Constants.TortoiseGoofy, Cost = Constants.Cost750, Value = 0x61B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy Tortoise", ImageUrl = "Characters/Tortoise_Goofy.png" },
                        //new ButtonTemplate { Name = Constants.Beast, Cost = Constants.Cost750, Value = 0x5E, ManipulationType = ManipulationType.Set, Description = "Switch Model to Beast", ImageUrl = "Characters/Beast.png" },
                        new ButtonTemplate { Name = Constants.Ping, Cost = Constants.Cost750, Value = 0x64, ManipulationType = ManipulationType.Set, Description = "Switch Model to Ping", ImageUrl = "Characters/Ping.png" },
                        new ButtonTemplate { Name = Constants.Mulan, Cost = Constants.Cost750, Value = 0x63, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mulan", ImageUrl = "Characters/Mulan.png" },
                        new ButtonTemplate { Name = Constants.Auron, Cost = Constants.Cost750, Value = 0x65, ManipulationType = ManipulationType.Set, Description = "Switch Model to Auron", ImageUrl = "Characters/Auron.png" },
                        new ButtonTemplate { Name = Constants.Aladdin, Cost = Constants.Cost750, Value = 0x62, ManipulationType = ManipulationType.Set, Description = "Switch Model to Aladdin", ImageUrl = "Characters/Aladdin.png" },
                        new ButtonTemplate { Name = Constants.JackSparrow, Cost = Constants.Cost750, Value = 0x66, ManipulationType = ManipulationType.Set, Description = "Switch Model to Captain Jack Sparrow", ImageUrl = "Characters/Jack_Sparrow.png" },
                        new ButtonTemplate { Name = Constants.HalloweenJack, Cost = Constants.Cost750, Value = 0x5F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Halloween Town Jack", ImageUrl = "Characters/Halloween_Jack.png" },
                        new ButtonTemplate { Name = Constants.ChristmasJack, Cost = Constants.Cost750, Value = 0x60, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Jack", ImageUrl = "Characters/Christmas_Jack.png" },
                        new ButtonTemplate { Name = Constants.Simba, Cost = Constants.Cost750, Value = 0x61, ManipulationType = ManipulationType.Set, Description = "Switch Model to Simba", ImageUrl = "Characters/Simba.png" },
                        new ButtonTemplate { Name = Constants.Tron, Cost = Constants.Cost750, Value = 0x2D4, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Tron.png" },

                        new ButtonTemplate { Name = Constants.ValorForm, Cost = Constants.Cost2000, Value = 0x55, ManipulationType = ManipulationType.Set, Description = "Switch Model to Valor Form", ImageUrl = "Characters/Valor_Sora.png" },
                        new ButtonTemplate { Name = Constants.WisdomForm, Cost = Constants.Cost2000, Value = 0x56, ManipulationType = ManipulationType.Set, Description = "Switch Model to Wisdom Form", ImageUrl = "Characters/Wisdom_Sora.png" },
                        new ButtonTemplate { Name = Constants.LimitForm, Cost = Constants.Cost2000, Value = 0x95D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Limit Form", ImageUrl = "Characters/Limit_Sora.png" },
                        new ButtonTemplate { Name = Constants.MasterForm, Cost = Constants.Cost2000, Value = 0x57, ManipulationType = ManipulationType.Set, Description = "Switch Model to Master Form", ImageUrl = "Characters/Master_Sora.png" },
                        new ButtonTemplate { Name = Constants.FinalForm, Cost = Constants.Cost2000, Value = 0x58, ManipulationType = ManipulationType.Set, Description = "Switch Model to Final Form", ImageUrl = "Characters/Final_Sora.png" },
                        new ButtonTemplate { Name = Constants.Antiform, Cost = Constants.Cost3000, Value = 0x59, ManipulationType = ManipulationType.Set, Description = "Switch Model to Anti Form", ImageUrl = "Characters/Anti_Sora.png" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Timeless River Sora",
                    Category = GroupType.ModelSwap,
                    Cost = 0,
                    Description = "Choose which Character will replace Timeless River Sora",
                    ImageUrl = "Characters/Timeless_River_Sora.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = Constants.TimelessRiverSora, Cost = Constants.Cost500, Value = 0x955, ManipulationType = ManipulationType.Set, Description = "Switch Model to Timeless River Sora", ImageUrl = "Characters/Timeless_River_Sora.png" },

                        new ButtonTemplate { Name = Constants.Sora, Cost = Constants.Cost500, Value = 0x54, ManipulationType = ManipulationType.Set, Description = "Revert Sora to KH2 Model", ImageUrl = "Characters/Sora.png" },
                        new ButtonTemplate { Name = Constants.KH1Sora, Cost = Constants.Cost500, Value = 0x6C1, ManipulationType = ManipulationType.Set, Description = "Switch Model to KH1 Sora", ImageUrl = "Characters/KH1_Sora.png" },
                        new ButtonTemplate { Name = Constants.CardSora, Cost = Constants.Cost1000, Value = 0x601, ManipulationType = ManipulationType.Set, Description = "Switch Model to Card Sora", ImageUrl = "Characters/Card_Sora.png" },
                        new ButtonTemplate { Name = Constants.DieSora, Cost = Constants.Cost1000, Value = 0x602, ManipulationType = ManipulationType.Set, Description = "Switch Model to Die Sora", ImageUrl = "Characters/Die_Sora.png" },
                        new ButtonTemplate { Name = Constants.LionSora, Cost = Constants.Cost750, Value = 0x28A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Lion Sora", ImageUrl = "Characters/Lion_Sora.png" },
                        new ButtonTemplate { Name = Constants.Roxas, Cost = Constants.Cost750, Value = 0x5A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Roxas", ImageUrl = "Characters/Roxas.png" },
                        new ButtonTemplate { Name = Constants.DualwieldRoxas, Cost = Constants.Cost1000, Value = 0x323, ManipulationType = ManipulationType.Set, Description = "Switch Model to Dualwield Roxas", ImageUrl = "Characters/Roxas_Dualwield.png" },
                        new ButtonTemplate { Name = Constants.MickeyRobed, Cost = Constants.Cost500, Value = 0x5B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Robed Mickey", ImageUrl = "Characters/Mickey_Robed.png" },
                        new ButtonTemplate { Name = Constants.Mickey, Cost = Constants.Cost500, Value = 0x318, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mickey", ImageUrl = "Characters/Mickey.png" },

                        new ButtonTemplate { Name = Constants.Donald, Cost = Constants.Cost750, Value = 0x5C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald", ImageUrl = "Characters/Donald.png" },
                        new ButtonTemplate { Name = Constants.Goofy, Cost = Constants.Cost750, Value = 0x5D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy", ImageUrl = "Characters/Goofy.png" },
                        new ButtonTemplate { Name = Constants.BirdDonald, Cost = Constants.Cost750, Value = 0x5EF, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald Bird", ImageUrl = "Characters/Bird_Donald.png" },
                        new ButtonTemplate { Name = Constants.TortoiseGoofy, Cost = Constants.Cost750, Value = 0x61B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy Tortoise", ImageUrl = "Characters/Tortoise_Goofy.png" },
                        //new ButtonTemplate { Name = Constants.Beast, Cost = Constants.Cost750, Value = 0x5E, ManipulationType = ManipulationType.Set, Description = "Switch Model to Beast", ImageUrl = "Characters/Beast.png" },
                        new ButtonTemplate { Name = Constants.Ping, Cost = Constants.Cost750, Value = 0x64, ManipulationType = ManipulationType.Set, Description = "Switch Model to Ping", ImageUrl = "Characters/Ping.png" },
                        new ButtonTemplate { Name = Constants.Mulan, Cost = Constants.Cost750, Value = 0x63, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mulan", ImageUrl = "Characters/Mulan.png" },
                        new ButtonTemplate { Name = Constants.Auron, Cost = Constants.Cost750, Value = 0x65, ManipulationType = ManipulationType.Set, Description = "Switch Model to Auron", ImageUrl = "Characters/Auron.png" },
                        new ButtonTemplate { Name = Constants.Aladdin, Cost = Constants.Cost750, Value = 0x62, ManipulationType = ManipulationType.Set, Description = "Switch Model to Aladdin", ImageUrl = "Characters/Aladdin.png" },
                        new ButtonTemplate { Name = Constants.JackSparrow, Cost = Constants.Cost750, Value = 0x66, ManipulationType = ManipulationType.Set, Description = "Switch Model to Captain Jack Sparrow", ImageUrl = "Characters/Jack_Sparrow.png" },
                        new ButtonTemplate { Name = Constants.HalloweenJack, Cost = Constants.Cost750, Value = 0x5F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Halloween Town Jack", ImageUrl = "Characters/Halloween_Jack.png" },
                        new ButtonTemplate { Name = Constants.ChristmasJack, Cost = Constants.Cost750, Value = 0x60, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Jack", ImageUrl = "Characters/Christmas_Jack.png" },
                        new ButtonTemplate { Name = Constants.Simba, Cost = Constants.Cost750, Value = 0x61, ManipulationType = ManipulationType.Set, Description = "Switch Model to Simba", ImageUrl = "Characters/Simba.png" },
                        new ButtonTemplate { Name = Constants.Tron, Cost = Constants.Cost750, Value = 0x2D4, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Tron.png" },

                        new ButtonTemplate { Name = Constants.ValorForm, Cost = Constants.Cost2000, Value = 0x55, ManipulationType = ManipulationType.Set, Description = "Switch Model to Valor Form", ImageUrl = "Characters/Valor_Sora.png" },
                        new ButtonTemplate { Name = Constants.WisdomForm, Cost = Constants.Cost2000, Value = 0x56, ManipulationType = ManipulationType.Set, Description = "Switch Model to Wisdom Form", ImageUrl = "Characters/Wisdom_Sora.png" },
                        new ButtonTemplate { Name = Constants.LimitForm, Cost = Constants.Cost2000, Value = 0x95D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Limit Form", ImageUrl = "Characters/Limit_Sora.png" },
                        new ButtonTemplate { Name = Constants.MasterForm, Cost = Constants.Cost2000, Value = 0x57, ManipulationType = ManipulationType.Set, Description = "Switch Model to Master Form", ImageUrl = "Characters/Master_Sora.png" },
                        new ButtonTemplate { Name = Constants.FinalForm, Cost = Constants.Cost2000, Value = 0x58, ManipulationType = ManipulationType.Set, Description = "Switch Model to Final Form", ImageUrl = "Characters/Final_Sora.png" },
                        new ButtonTemplate { Name = Constants.Antiform, Cost = Constants.Cost3000, Value = 0x59, ManipulationType = ManipulationType.Set, Description = "Switch Model to Anti Form", ImageUrl = "Characters/Anti_Sora.png" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Halloween Sora",
                    Category = GroupType.ModelSwap,
                    Cost = 0,
                    Description = "Choose which Character will replace Halloween Sora",
                    ImageUrl = "Characters/Halloween_Sora.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = Constants.HalloweenSora, Cost = Constants.Cost500, Value = 0x2B5, ManipulationType = ManipulationType.Set, Description = "Switch Model to Halloween Town Sora", ImageUrl = "Characters/Halloween_Sora.png" },

                        new ButtonTemplate { Name = Constants.Sora, Cost = Constants.Cost500, Value = 0x54, ManipulationType = ManipulationType.Set, Description = "Revert Sora to KH2 Model", ImageUrl = "Characters/Sora.png" },
                        new ButtonTemplate { Name = Constants.KH1Sora, Cost = Constants.Cost500, Value = 0x6C1, ManipulationType = ManipulationType.Set, Description = "Switch Model to KH1 Sora", ImageUrl = "Characters/KH1_Sora.png" },
                        new ButtonTemplate { Name = Constants.CardSora, Cost = Constants.Cost1000, Value = 0x601, ManipulationType = ManipulationType.Set, Description = "Switch Model to Card Sora", ImageUrl = "Characters/Card_Sora.png" },
                        new ButtonTemplate { Name = Constants.DieSora, Cost = Constants.Cost1000, Value = 0x602, ManipulationType = ManipulationType.Set, Description = "Switch Model to Die Sora", ImageUrl = "Characters/Die_Sora.png" },
                        new ButtonTemplate { Name = Constants.LionSora, Cost = Constants.Cost750, Value = 0x28A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Lion Sora", ImageUrl = "Characters/Lion_Sora.png" },
                        new ButtonTemplate { Name = Constants.Roxas, Cost = Constants.Cost750, Value = 0x5A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Roxas", ImageUrl = "Characters/Roxas.png" },
                        new ButtonTemplate { Name = Constants.DualwieldRoxas, Cost = Constants.Cost1000, Value = 0x323, ManipulationType = ManipulationType.Set, Description = "Switch Model to Dualwield Roxas", ImageUrl = "Characters/Roxas_Dualwield.png" },
                        new ButtonTemplate { Name = Constants.MickeyRobed, Cost = Constants.Cost500, Value = 0x5B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Robed Mickey", ImageUrl = "Characters/Mickey_Robed.png" },
                        new ButtonTemplate { Name = Constants.Mickey, Cost = Constants.Cost500, Value = 0x318, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mickey", ImageUrl = "Characters/Mickey.png" },

                        new ButtonTemplate { Name = Constants.Donald, Cost = Constants.Cost750, Value = 0x5C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald", ImageUrl = "Characters/Donald.png" },
                        new ButtonTemplate { Name = Constants.Goofy, Cost = Constants.Cost750, Value = 0x5D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy", ImageUrl = "Characters/Goofy.png" },
                        new ButtonTemplate { Name = Constants.BirdDonald, Cost = Constants.Cost750, Value = 0x5EF, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald Bird", ImageUrl = "Characters/Bird_Donald.png" },
                        new ButtonTemplate { Name = Constants.TortoiseGoofy, Cost = Constants.Cost750, Value = 0x61B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy Tortoise", ImageUrl = "Characters/Tortoise_Goofy.png" },
                        //new ButtonTemplate { Name = Constants.Beast, Cost = Constants.Cost750, Value = 0x5E, ManipulationType = ManipulationType.Set, Description = "Switch Model to Beast", ImageUrl = "Characters/Beast.png" },
                        new ButtonTemplate { Name = Constants.Ping, Cost = Constants.Cost750, Value = 0x64, ManipulationType = ManipulationType.Set, Description = "Switch Model to Ping", ImageUrl = "Characters/Ping.png" },
                        new ButtonTemplate { Name = Constants.Mulan, Cost = Constants.Cost750, Value = 0x63, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mulan", ImageUrl = "Characters/Mulan.png" },
                        new ButtonTemplate { Name = Constants.Auron, Cost = Constants.Cost750, Value = 0x65, ManipulationType = ManipulationType.Set, Description = "Switch Model to Auron", ImageUrl = "Characters/Auron.png" },
                        new ButtonTemplate { Name = Constants.Aladdin, Cost = Constants.Cost750, Value = 0x62, ManipulationType = ManipulationType.Set, Description = "Switch Model to Aladdin", ImageUrl = "Characters/Aladdin.png" },
                        new ButtonTemplate { Name = Constants.JackSparrow, Cost = Constants.Cost750, Value = 0x66, ManipulationType = ManipulationType.Set, Description = "Switch Model to Captain Jack Sparrow", ImageUrl = "Characters/Jack_Sparrow.png" },
                        new ButtonTemplate { Name = Constants.HalloweenJack, Cost = Constants.Cost750, Value = 0x5F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Halloween Town Jack", ImageUrl = "Characters/Halloween_Jack.png" },
                        new ButtonTemplate { Name = Constants.ChristmasJack, Cost = Constants.Cost750, Value = 0x60, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Jack", ImageUrl = "Characters/Christmas_Jack.png" },
                        new ButtonTemplate { Name = Constants.Simba, Cost = Constants.Cost750, Value = 0x61, ManipulationType = ManipulationType.Set, Description = "Switch Model to Simba", ImageUrl = "Characters/Simba.png" },
                        new ButtonTemplate { Name = Constants.Tron, Cost = Constants.Cost750, Value = 0x2D4, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Tron.png" },

                        new ButtonTemplate { Name = Constants.ValorForm, Cost = Constants.Cost2000, Value = 0x55, ManipulationType = ManipulationType.Set, Description = "Switch Model to Valor Form", ImageUrl = "Characters/Valor_Sora.png" },
                        new ButtonTemplate { Name = Constants.WisdomForm, Cost = Constants.Cost2000, Value = 0x56, ManipulationType = ManipulationType.Set, Description = "Switch Model to Wisdom Form", ImageUrl = "Characters/Wisdom_Sora.png" },
                        new ButtonTemplate { Name = Constants.LimitForm, Cost = Constants.Cost2000, Value = 0x95D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Limit Form", ImageUrl = "Characters/Limit_Sora.png" },
                        new ButtonTemplate { Name = Constants.MasterForm, Cost = Constants.Cost2000, Value = 0x57, ManipulationType = ManipulationType.Set, Description = "Switch Model to Master Form", ImageUrl = "Characters/Master_Sora.png" },
                        new ButtonTemplate { Name = Constants.FinalForm, Cost = Constants.Cost2000, Value = 0x58, ManipulationType = ManipulationType.Set, Description = "Switch Model to Final Form", ImageUrl = "Characters/Final_Sora.png" },
                        new ButtonTemplate { Name = Constants.Antiform, Cost = Constants.Cost3000, Value = 0x59, ManipulationType = ManipulationType.Set, Description = "Switch Model to Anti Form", ImageUrl = "Characters/Anti_Sora.png" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Christmas Sora",
                    Category = GroupType.ModelSwap,
                    Cost = 0,
                    Description = "Choose which Character will replace Christmas Sora",
                    ImageUrl = "Characters/Christmas_Sora.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {   
                        new ButtonTemplate { Name = Constants.ChristmasSora, Cost = Constants.Cost500, Value = 0x955, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Sora", ImageUrl = "Characters/Christmas_Sora.png" },

                        new ButtonTemplate { Name = Constants.Sora, Cost = Constants.Cost500, Value = 0x54, ManipulationType = ManipulationType.Set, Description = "Revert Sora to KH2 Model", ImageUrl = "Characters/Sora.png" },
                        new ButtonTemplate { Name = Constants.KH1Sora, Cost = Constants.Cost500, Value = 0x6C1, ManipulationType = ManipulationType.Set, Description = "Switch Model to KH1 Sora", ImageUrl = "Characters/KH1_Sora.png" },
                        new ButtonTemplate { Name = Constants.CardSora, Cost = Constants.Cost1000, Value = 0x601, ManipulationType = ManipulationType.Set, Description = "Switch Model to Card Sora", ImageUrl = "Characters/Card_Sora.png" },
                        new ButtonTemplate { Name = Constants.DieSora, Cost = Constants.Cost1000, Value = 0x602, ManipulationType = ManipulationType.Set, Description = "Switch Model to Die Sora", ImageUrl = "Characters/Die_Sora.png" },
                        new ButtonTemplate { Name = Constants.LionSora, Cost = Constants.Cost750, Value = 0x28A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Lion Sora", ImageUrl = "Characters/Lion_Sora.png" },
                        new ButtonTemplate { Name = Constants.Roxas, Cost = Constants.Cost750, Value = 0x5A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Roxas", ImageUrl = "Characters/Roxas.png" },
                        new ButtonTemplate { Name = Constants.DualwieldRoxas, Cost = Constants.Cost1000, Value = 0x323, ManipulationType = ManipulationType.Set, Description = "Switch Model to Dualwield Roxas", ImageUrl = "Characters/Roxas_Dualwield.png" },
                        new ButtonTemplate { Name = Constants.MickeyRobed, Cost = Constants.Cost500, Value = 0x5B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Robed Mickey", ImageUrl = "Characters/Mickey_Robed.png" },
                        new ButtonTemplate { Name = Constants.Mickey, Cost = Constants.Cost500, Value = 0x318, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mickey", ImageUrl = "Characters/Mickey.png" },

                        new ButtonTemplate { Name = Constants.Donald, Cost = Constants.Cost750, Value = 0x5C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald", ImageUrl = "Characters/Donald.png" },
                        new ButtonTemplate { Name = Constants.Goofy, Cost = Constants.Cost750, Value = 0x5D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy", ImageUrl = "Characters/Goofy.png" },
                        new ButtonTemplate { Name = Constants.BirdDonald, Cost = Constants.Cost750, Value = 0x5EF, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald Bird", ImageUrl = "Characters/Bird_Donald.png" },
                        new ButtonTemplate { Name = Constants.TortoiseGoofy, Cost = Constants.Cost750, Value = 0x61B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy Tortoise", ImageUrl = "Characters/Tortoise_Goofy.png" },
                        //new ButtonTemplate { Name = Constants.Beast, Cost = Constants.Cost750, Value = 0x5E, ManipulationType = ManipulationType.Set, Description = "Switch Model to Beast", ImageUrl = "Characters/Beast.png" },
                        new ButtonTemplate { Name = Constants.Ping, Cost = Constants.Cost750, Value = 0x64, ManipulationType = ManipulationType.Set, Description = "Switch Model to Ping", ImageUrl = "Characters/Ping.png" },
                        new ButtonTemplate { Name = Constants.Mulan, Cost = Constants.Cost750, Value = 0x63, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mulan", ImageUrl = "Characters/Mulan.png" },
                        new ButtonTemplate { Name = Constants.Auron, Cost = Constants.Cost750, Value = 0x65, ManipulationType = ManipulationType.Set, Description = "Switch Model to Auron", ImageUrl = "Characters/Auron.png" },
                        new ButtonTemplate { Name = Constants.Aladdin, Cost = Constants.Cost750, Value = 0x62, ManipulationType = ManipulationType.Set, Description = "Switch Model to Aladdin", ImageUrl = "Characters/Aladdin.png" },
                        new ButtonTemplate { Name = Constants.JackSparrow, Cost = Constants.Cost750, Value = 0x66, ManipulationType = ManipulationType.Set, Description = "Switch Model to Captain Jack Sparrow", ImageUrl = "Characters/Jack_Sparrow.png" },
                        new ButtonTemplate { Name = Constants.HalloweenJack, Cost = Constants.Cost750, Value = 0x5F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Halloween Town Jack", ImageUrl = "Characters/Halloween_Jack.png" },
                        new ButtonTemplate { Name = Constants.ChristmasJack, Cost = Constants.Cost750, Value = 0x60, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Jack", ImageUrl = "Characters/Christmas_Jack.png" },
                        new ButtonTemplate { Name = Constants.Simba, Cost = Constants.Cost750, Value = 0x61, ManipulationType = ManipulationType.Set, Description = "Switch Model to Simba", ImageUrl = "Characters/Simba.png" },
                        new ButtonTemplate { Name = Constants.Tron, Cost = Constants.Cost750, Value = 0x2D4, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Tron.png" },

                        new ButtonTemplate { Name = Constants.ValorForm, Cost = Constants.Cost2000, Value = 0x55, ManipulationType = ManipulationType.Set, Description = "Switch Model to Valor Form", ImageUrl = "Characters/Valor_Sora.png" },
                        new ButtonTemplate { Name = Constants.WisdomForm, Cost = Constants.Cost2000, Value = 0x56, ManipulationType = ManipulationType.Set, Description = "Switch Model to Wisdom Form", ImageUrl = "Characters/Wisdom_Sora.png" },
                        new ButtonTemplate { Name = Constants.LimitForm, Cost = Constants.Cost2000, Value = 0x95D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Limit Form", ImageUrl = "Characters/Limit_Sora.png" },
                        new ButtonTemplate { Name = Constants.MasterForm, Cost = Constants.Cost2000, Value = 0x57, ManipulationType = ManipulationType.Set, Description = "Switch Model to Master Form", ImageUrl = "Characters/Master_Sora.png" },
                        new ButtonTemplate { Name = Constants.FinalForm, Cost = Constants.Cost2000, Value = 0x58, ManipulationType = ManipulationType.Set, Description = "Switch Model to Final Form", ImageUrl = "Characters/Final_Sora.png" },
                        new ButtonTemplate { Name = Constants.Antiform, Cost = Constants.Cost3000, Value = 0x59, ManipulationType = ManipulationType.Set, Description = "Switch Model to Anti Form", ImageUrl = "Characters/Anti_Sora.png" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Space Paranoids Sora",
                    Category = GroupType.ModelSwap,
                    Cost = 0,
                    Description = "Choose which Character will replace Space Paranoids Sora",
                    ImageUrl = "Characters/Space_Paranoids_Sora.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = Constants.SpaceParanoidsSora, Cost = Constants.Cost500, Value = 0x656, ManipulationType = ManipulationType.Set, Description = "Switch Model to Space Paranoids Sora", ImageUrl = "Characters/Space_Paranoids_Sora.png" },
                        
                        new ButtonTemplate { Name = Constants.Sora, Cost = Constants.Cost500, Value = 0x54, ManipulationType = ManipulationType.Set, Description = "Revert Sora to KH2 Model", ImageUrl = "Characters/Sora.png" },
                        new ButtonTemplate { Name = Constants.KH1Sora, Cost = Constants.Cost500, Value = 0x6C1, ManipulationType = ManipulationType.Set, Description = "Switch Model to KH1 Sora", ImageUrl = "Characters/KH1_Sora.png" },
                        new ButtonTemplate { Name = Constants.CardSora, Cost = Constants.Cost1000, Value = 0x601, ManipulationType = ManipulationType.Set, Description = "Switch Model to Card Sora", ImageUrl = "Characters/Card_Sora.png" },
                        new ButtonTemplate { Name = Constants.DieSora, Cost = Constants.Cost1000, Value = 0x602, ManipulationType = ManipulationType.Set, Description = "Switch Model to Die Sora", ImageUrl = "Characters/Die_Sora.png" },
                        new ButtonTemplate { Name = Constants.LionSora, Cost = Constants.Cost750, Value = 0x28A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Lion Sora", ImageUrl = "Characters/Lion_Sora.png" },
                        new ButtonTemplate { Name = Constants.Roxas, Cost = Constants.Cost750, Value = 0x5A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Roxas", ImageUrl = "Characters/Roxas.png" },
                        new ButtonTemplate { Name = Constants.DualwieldRoxas, Cost = Constants.Cost1000, Value = 0x323, ManipulationType = ManipulationType.Set, Description = "Switch Model to Dualwield Roxas", ImageUrl = "Characters/Roxas_Dualwield.png" },
                        new ButtonTemplate { Name = Constants.MickeyRobed, Cost = Constants.Cost500, Value = 0x5B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Robed Mickey", ImageUrl = "Characters/Mickey_Robed.png" },
                        new ButtonTemplate { Name = Constants.Mickey, Cost = Constants.Cost500, Value = 0x318, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mickey", ImageUrl = "Characters/Mickey.png" },

                        new ButtonTemplate { Name = Constants.Donald, Cost = Constants.Cost750, Value = 0x5C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald", ImageUrl = "Characters/Donald.png" },
                        new ButtonTemplate { Name = Constants.Goofy, Cost = Constants.Cost750, Value = 0x5D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy", ImageUrl = "Characters/Goofy.png" },
                        new ButtonTemplate { Name = Constants.BirdDonald, Cost = Constants.Cost750, Value = 0x5EF, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald Bird", ImageUrl = "Characters/Bird_Donald.png" },
                        new ButtonTemplate { Name = Constants.TortoiseGoofy, Cost = Constants.Cost750, Value = 0x61B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Goofy Tortoise", ImageUrl = "Characters/Tortoise_Goofy.png" },
                        //new ButtonTemplate { Name = Constants.Beast, Cost = Constants.Cost750, Value = 0x5E, ManipulationType = ManipulationType.Set, Description = "Switch Model to Beast", ImageUrl = "Characters/Beast.png" },
                        new ButtonTemplate { Name = Constants.Ping, Cost = Constants.Cost750, Value = 0x64, ManipulationType = ManipulationType.Set, Description = "Switch Model to Ping", ImageUrl = "Characters/Ping.png" },
                        new ButtonTemplate { Name = Constants.Mulan, Cost = Constants.Cost750, Value = 0x63, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mulan", ImageUrl = "Characters/Mulan.png" },
                        new ButtonTemplate { Name = Constants.Auron, Cost = Constants.Cost750, Value = 0x65, ManipulationType = ManipulationType.Set, Description = "Switch Model to Auron", ImageUrl = "Characters/Auron.png" },
                        new ButtonTemplate { Name = Constants.Aladdin, Cost = Constants.Cost750, Value = 0x62, ManipulationType = ManipulationType.Set, Description = "Switch Model to Aladdin", ImageUrl = "Characters/Aladdin.png" },
                        new ButtonTemplate { Name = Constants.JackSparrow, Cost = Constants.Cost750, Value = 0x66, ManipulationType = ManipulationType.Set, Description = "Switch Model to Captain Jack Sparrow", ImageUrl = "Characters/Jack_Sparrow.png" },
                        new ButtonTemplate { Name = Constants.HalloweenJack, Cost = Constants.Cost750, Value = 0x5F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Halloween Town Jack", ImageUrl = "Characters/Halloween_Jack.png" },
                        new ButtonTemplate { Name = Constants.ChristmasJack, Cost = Constants.Cost750, Value = 0x60, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Jack", ImageUrl = "Characters/Christmas_Jack.png" },
                        new ButtonTemplate { Name = Constants.Simba, Cost = Constants.Cost750, Value = 0x61, ManipulationType = ManipulationType.Set, Description = "Switch Model to Simba", ImageUrl = "Characters/Simba.png" },
                        new ButtonTemplate { Name = Constants.Tron, Cost = Constants.Cost750, Value = 0x2D4, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Tron.png" },

                        new ButtonTemplate { Name = Constants.ValorForm, Cost = Constants.Cost2000, Value = 0x55, ManipulationType = ManipulationType.Set, Description = "Switch Model to Valor Form", ImageUrl = "Characters/Valor_Sora.png" },
                        new ButtonTemplate { Name = Constants.WisdomForm, Cost = Constants.Cost2000, Value = 0x56, ManipulationType = ManipulationType.Set, Description = "Switch Model to Wisdom Form", ImageUrl = "Characters/Wisdom_Sora.png" },
                        new ButtonTemplate { Name = Constants.LimitForm, Cost = Constants.Cost2000, Value = 0x95D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Limit Form", ImageUrl = "Characters/Limit_Sora.png" },
                        new ButtonTemplate { Name = Constants.MasterForm, Cost = Constants.Cost2000, Value = 0x57, ManipulationType = ManipulationType.Set, Description = "Switch Model to Master Form", ImageUrl = "Characters/Master_Sora.png" },
                        new ButtonTemplate { Name = Constants.FinalForm, Cost = Constants.Cost2000, Value = 0x58, ManipulationType = ManipulationType.Set, Description = "Switch Model to Final Form", ImageUrl = "Characters/Final_Sora.png" },
                        new ButtonTemplate { Name = Constants.Antiform, Cost = Constants.Cost3000, Value = 0x59, ManipulationType = ManipulationType.Set, Description = "Switch Model to Anti Form", ImageUrl = "Characters/Anti_Sora.png" },
                    }
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Sora")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Lion Sora")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraLionModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Timeless River Sora")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraTimelessRiverModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Halloween Sora")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraHalloweenModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Christmas Sora")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraChristmasModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Space Paranoids Sora")).SubMethodParams.ForEach(x => x.MethodName = "SendSoraSpaceParanoidsModelMessage");

            return options;
        }
    }
}