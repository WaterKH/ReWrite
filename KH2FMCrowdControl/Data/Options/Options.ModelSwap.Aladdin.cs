using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeAladdinModelSwapOptions()
        {
            var ally = new List<ButtonTemplate>
            {                
                new ButtonTemplate { Name = Constants.Aladdin, Cost = Constants.Cost750, Value = 0x62, ManipulationType = ManipulationType.Set, Description = "Switch Model to Aladdin", ImageUrl = "Characters/Aladdin.png" },

                new ButtonTemplate { Name = Constants.Donald, Cost = Constants.Cost750, Value = 0x5C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Donald", ImageUrl = "Characters/Donald.png" },
                new ButtonTemplate { Name = Constants.BirdDonald, Cost = Constants.Cost750, Value = 0x5EF, ManipulationType = ManipulationType.Set, Description = "Switch Model to Bird Donald", ImageUrl = "Characters/Bird_Donald.png" },
                //new ButtonTemplate { Name = Constants.HalloweenDonald, Cost = Constants.Cost750, Value = 0x29E, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Goofy", ImageUrl = "Characters/Christmas_Goofy.png" },
                //new ButtonTemplate { Name = Constants.ChristmasDonald, Cost = Constants.Cost750, Value = 0x95B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Donald", ImageUrl = "Characters/Christmas_Donald.png" },
                //new ButtonTemplate { Name = Constants.SpaceParanoidsDonald, Cost = Constants.Cost750, Value = 0x55A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Goofy", ImageUrl = "Characters/Christmas_Goofy.png" },
                //new ButtonTemplate { Name = Constants.TimelessRiverDonald, Cost = Constants.Cost750, Value = 0x5CF, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Goofy", ImageUrl = "Characters/Christmas_Goofy.png" },

                new ButtonTemplate { Name = Constants.Goofy, Cost = Constants.Cost500, Value = 0x5D, ManipulationType = ManipulationType.Set, Description = "Revert Goofy to KH2 Model", ImageUrl = "Characters/Goofy.png" },
                new ButtonTemplate { Name = Constants.TortoiseGoofy, Cost = Constants.Cost750, Value = 0x61B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tortoise Goofy", ImageUrl = "Characters/Tortoise_Goofy.png" },
                //new ButtonTemplate { Name = Constants.HalloweenGoofy, Cost = Constants.Cost750, Value = 0x29D, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Goofy", ImageUrl = "Characters/Christmas_Goofy.png" },
                //new ButtonTemplate { Name = Constants.ChristmasGoofy, Cost = Constants.Cost750, Value = 0x95C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Goofy", ImageUrl = "Characters/Christmas_Goofy.png" },
                //new ButtonTemplate { Name = Constants.SpaceParanoidsGoofy, Cost = Constants.Cost750, Value = 0x554, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Goofy", ImageUrl = "Characters/Christmas_Goofy.png" },
                //new ButtonTemplate { Name = Constants.TimelessRiverGoofy, Cost = Constants.Cost750, Value = 0x4F5, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Goofy", ImageUrl = "Characters/Christmas_Goofy.png" },


                new ButtonTemplate { Name = Constants.Riku, Cost = Constants.Cost1000, Value = 0x819, ManipulationType = ManipulationType.Set, Description = "Switch Model to Riku", ImageUrl = "Characters/Riku.png" },
                new ButtonTemplate { Name = Constants.Axel, Cost = Constants.Cost1000, Value = 0x4DC, ManipulationType = ManipulationType.Set, Description = "Switch Model to Axel", ImageUrl = "Characters/Axel.png" },
                new ButtonTemplate { Name = Constants.Leon, Cost = Constants.Cost500, Value = 0x61C, ManipulationType = ManipulationType.Set, Description = "Switch Model to Leon", ImageUrl = "Characters/Leon.png" },
                new ButtonTemplate { Name = Constants.Yuffie, Cost = Constants.Cost500, Value = 0x6B0, ManipulationType = ManipulationType.Set, Description = "Switch Model to Yuffie", ImageUrl = "Characters/Yuffie.png" },
                new ButtonTemplate { Name = Constants.Tifa, Cost = Constants.Cost500, Value = 0x6B3, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tifa", ImageUrl = "Characters/Tifa.png" },
                new ButtonTemplate { Name = Constants.Cloud, Cost = Constants.Cost500, Value = 0x688, ManipulationType = ManipulationType.Set, Description = "Switch Model to Cloud", ImageUrl = "Characters/Cloud.png" },

                new ButtonTemplate { Name = Constants.Beast, Cost = Constants.Cost750, Value = 0x5E, ManipulationType = ManipulationType.Set, Description = "Switch Model to Beast", ImageUrl = "Characters/Beast.png" },
                new ButtonTemplate { Name = Constants.Ping, Cost = Constants.Cost750, Value = 0x64, ManipulationType = ManipulationType.Set, Description = "Switch Model to Ping", ImageUrl = "Characters/Ping.png" },
                new ButtonTemplate { Name = Constants.Mulan, Cost = Constants.Cost750, Value = 0x63, ManipulationType = ManipulationType.Set, Description = "Switch Model to Mulan", ImageUrl = "Characters/Mulan.png" },
                new ButtonTemplate { Name = Constants.Auron, Cost = Constants.Cost750, Value = 0x65, ManipulationType = ManipulationType.Set, Description = "Switch Model to Auron", ImageUrl = "Characters/Auron.png" },
                new ButtonTemplate { Name = Constants.JackSparrow, Cost = Constants.Cost750, Value = 0x66, ManipulationType = ManipulationType.Set, Description = "Switch Model to Captain Jack Sparrow", ImageUrl = "Characters/Jack_Sparrow.png" },
                new ButtonTemplate { Name = Constants.HalloweenJack, Cost = Constants.Cost750, Value = 0x5F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Halloween Town Jack", ImageUrl = "Characters/Halloween_Jack.png" },
                new ButtonTemplate { Name = Constants.ChristmasJack, Cost = Constants.Cost750, Value = 0x60, ManipulationType = ManipulationType.Set, Description = "Switch Model to Christmas Town Jack", ImageUrl = "Characters/Christmas_Jack.png" },
                new ButtonTemplate { Name = Constants.Simba, Cost = Constants.Cost750, Value = 0x61, ManipulationType = ManipulationType.Set, Description = "Switch Model to Simba", ImageUrl = "Characters/Simba.png" },
                new ButtonTemplate { Name = Constants.Tron, Cost = Constants.Cost750, Value = 0x2D4, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Tron.png" },
                new ButtonTemplate { Name = Constants.Hercules, Cost = Constants.Cost750, Value = 0x16A, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Hercules.png" },
                new ButtonTemplate { Name = Constants.Minnie, Cost = Constants.Cost750, Value = 0x4BB, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tron", ImageUrl = "Characters/Minnie.png" },
            };

            var enemy = new List<ButtonTemplate>
            {
                new ButtonTemplate { Name = Constants.Leon, Cost = Constants.Cost500, Value = 0x8F8, ManipulationType = ManipulationType.Set, Description = "Switch Model to Leon", ImageUrl = "Characters/Leon.png" },
                new ButtonTemplate { Name = Constants.Yuffie, Cost = Constants.Cost500, Value = 0x8FB, ManipulationType = ManipulationType.Set, Description = "Switch Model to Yuffie", ImageUrl = "Characters/Yuffie.png" },
                new ButtonTemplate { Name = Constants.Tifa, Cost = Constants.Cost500, Value = 0x8FA, ManipulationType = ManipulationType.Set, Description = "Switch Model to Tifa", ImageUrl = "Characters/Tifa.png" },
                new ButtonTemplate { Name = Constants.Cloud, Cost = Constants.Cost500, Value = 0x8F9, ManipulationType = ManipulationType.Set, Description = "Switch Model to Cloud", ImageUrl = "Characters/Cloud.png" },

                new ButtonTemplate { Name = Constants.Xemnas, Cost = Constants.Cost1000, Value = 0x81F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Xemnas", ImageUrl = "Characters/Xemnas.png" },
                new ButtonTemplate { Name = Constants.Xigbar, Cost = Constants.Cost1000, Value = 0x622, ManipulationType = ManipulationType.Set, Description = "Switch Model to Xigbar", ImageUrl = "Characters/Xigbar.png" },
                new ButtonTemplate { Name = Constants.Xaldin, Cost = Constants.Cost1000, Value = 0x3E5, ManipulationType = ManipulationType.Set, Description = "Switch Model to Xaldin", ImageUrl = "Characters/Xaldin.png" },
                new ButtonTemplate { Name = Constants.Vexen, Cost = Constants.Cost1000, Value = 0x933, ManipulationType = ManipulationType.Set, Description = "Switch Model to Vexen", ImageUrl = "Characters/Vexen.png" },
                new ButtonTemplate { Name = $"{Constants.Vexen}'s Anti-Sora", Cost = Constants.Cost1000, Value = 0x934, ManipulationType = ManipulationType.Set, Description = "Switch Model to Vexen's Anti-Sora", ImageUrl = "Characters/Vexen_AntiSora.png" },
                new ButtonTemplate { Name = Constants.Lexaeus, Cost = Constants.Cost1000, Value = 0x935, ManipulationType = ManipulationType.Set, Description = "Switch Model to Lexaeus", ImageUrl = "Characters/Lexaeus.png" },
                new ButtonTemplate { Name = Constants.Zexion, Cost = Constants.Cost1000, Value = 0x97B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Zexion", ImageUrl = "Characters/Zexion.png" },
                new ButtonTemplate { Name = Constants.Saix, Cost = Constants.Cost1000, Value = 0x6C9, ManipulationType = ManipulationType.Set, Description = "Switch Model to Saix", ImageUrl = "Characters/Saix.png" },
                new ButtonTemplate { Name = Constants.Axel, Cost = Constants.Cost1000, Value = 0x51, ManipulationType = ManipulationType.Set, Description = "Switch Model to Axel", ImageUrl = "Characters/Axel.png" },
                new ButtonTemplate { Name = Constants.Demyx, Cost = Constants.Cost1000, Value = 0x31B, ManipulationType = ManipulationType.Set, Description = "Switch Model to Demyx", ImageUrl = "Characters/Demyx.png" },
                new ButtonTemplate { Name = $"{Constants.Demyx}'s Water Clone", Cost = Constants.Cost1000, Value = 0x8F6, ManipulationType = ManipulationType.Set, Description = "Switch Model to Demyx's Water Clone", ImageUrl = "Characters/Demyx_Clone.png" },
                new ButtonTemplate { Name = Constants.Luxord, Cost = Constants.Cost1000, Value = 0x5F8, ManipulationType = ManipulationType.Set, Description = "Switch Model to Luxord", ImageUrl = "Characters/Luxord.png" },
                new ButtonTemplate { Name = Constants.Marluxia, Cost = Constants.Cost1000, Value = 0x923, ManipulationType = ManipulationType.Set, Description = "Switch Model to Marluxia", ImageUrl = "Characters/Marluxia.png" },
                new ButtonTemplate { Name = Constants.Larxene, Cost = Constants.Cost1000, Value = 0x962, ManipulationType = ManipulationType.Set, Description = "Switch Model to Larxene", ImageUrl = "Characters/Larxene.png" },
                new ButtonTemplate { Name = Constants.Roxas, Cost = Constants.Cost1000, Value = 0x951, ManipulationType = ManipulationType.Set, Description = "Switch Model to Roxas", ImageUrl = "Characters/Roxas.png" },
                new ButtonTemplate { Name = $"{Constants.Roxas}'s Shadow", Cost = Constants.Cost1000, Value = 0x754, ManipulationType = ManipulationType.Set, Description = "Switch Model to Roxas's Shadow", ImageUrl = "Characters/Roxas_Shadow.png" },

                new ButtonTemplate { Name = Constants.Sephiroth, Cost = Constants.Cost3000, Value = 0x8B6, ManipulationType = ManipulationType.Set, Description = "Switch Model to Sephiroth", ImageUrl = "Characters/Sephiroth.png" },
                new ButtonTemplate { Name = Constants.LingeringWill, Cost = Constants.Cost3000, Value = 0x96F, ManipulationType = ManipulationType.Set, Description = "Switch Model to Lingering Will", ImageUrl = "Characters/Lingering_Will.png" },
            };

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Aladdin (Ally)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Aladdin",
                    ImageUrl = "Characters/Aladdin.png",
                    SubMethodParams = ally
                },
                new ButtonTemplate
                {
                    Name = "Change Aladdin (Enemy)",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.Party,
                    Cost = 0,
                    Description = "Choose which Character will replace Aladdin",
                    ImageUrl = "Characters/Aladdin.png",
                    SubMethodParams = enemy
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Aladdin (Ally)")).SubMethodParams.ForEach(x => x.MethodName = "SendAladdinModelMessage");
            options.FirstOrDefault(x => x.Name.Equals("Change Aladdin (Enemy)")).SubMethodParams.ForEach(x => x.MethodName = "SendAladdinModelMessage");

            return options;
        }
    }
}