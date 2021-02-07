using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSoraMagicOptions()
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Give/ Take Fire Magic",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Give Fire/ Fira/ Firaga or Remove",
                    ImageUrl = "Sora/Magic/MagicFire1.png",
                    SubMethodParams = new List<ButtonTemplate>
                        {
                            new ButtonTemplate { Name = Constants.Take(Constants.Fire), Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Fire Element from Sora's Magic", ImageUrl = "Sora/Magic/MagicFire0.png", MethodName = "SendFireMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Fire), Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Fire to Sora's Magic", ImageUrl = "Sora/Magic/MagicFire1.png", MethodName = "SendFireMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Fira), Cost = Constants.Cost300, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Fira to Sora's Magic", ImageUrl = "Sora/Magic/MagicFire2.png", MethodName = "SendFireMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Firaga), Cost = Constants.Cost400, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Firaga to Sora's Magic", ImageUrl = "Sora/Magic/MagicFire3.png", MethodName = "SendFireMagicMessage" },
                        }
                },
                new ButtonTemplate
                {
                    Name = "Give/ Take Blizzard Magic",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Give Blizzard/ Blizzara/ Blizzaga or Remove",
                    ImageUrl = "Sora/Magic/MagicIce1.png",
                    SubMethodParams = new List<ButtonTemplate>
                        {
                            new ButtonTemplate { Name = Constants.Take(Constants.Blizzard), Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Blizzard Element from Sora's Magic", ImageUrl = "Sora/Magic/MagicIce0.png", MethodName = "SendBlizzardMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Blizzard), Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Blizzard to Sora's Magic", ImageUrl = "Sora/Magic/MagicIce1.png", MethodName = "SendBlizzardMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Blizzara), Cost = Constants.Cost300, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Blizzara to Sora's Magic", ImageUrl = "Sora/Magic/MagicIce2.png", MethodName = "SendBlizzardMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Blizzaga), Cost = Constants.Cost400, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Blizzaga to Sora's Magic", ImageUrl = "Sora/Magic/MagicIce3.png", MethodName = "SendBlizzardMagicMessage" },
                        }
                },
                new ButtonTemplate
                {
                    Name = "Give/ Take Thunder Magic",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Give Thunder/ Thundara/ Thundaga or Remove",
                    ImageUrl = "Sora/Magic/MagicThunder1.png",
                    SubMethodParams = new List<ButtonTemplate>
                        {
                            new ButtonTemplate { Name = Constants.Take(Constants.Thunder), Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Thunder Element from Sora's Magic", ImageUrl = "Sora/Magic/MagicThunder0.png", MethodName = "SendThunderMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Thunder), Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Thunder to Sora's Magic", ImageUrl = "Sora/Magic/MagicThunder1.png", MethodName = "SendThunderMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Thundara), Cost = Constants.Cost300, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Thundara to Sora's Magic", ImageUrl = "Sora/Magic/MagicThunder2.png", MethodName = "SendThunderMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Thundaga), Cost = Constants.Cost400, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Thundaga to Sora's Magic", ImageUrl = "Sora/Magic/MagicThunder3.png", MethodName = "SendThunderMagicMessage" },
                        }
                },
                new ButtonTemplate
                {
                    Name = "Give/ Take Cure Magic",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Give Cure/ Cura/ Curaga or Remove",
                    ImageUrl = "Sora/Magic/MagicCure1.png",
                    SubMethodParams = new List<ButtonTemplate>
                        {
                            new ButtonTemplate { Name = Constants.Take(Constants.Cure), Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Cure Element from Sora's Magic", ImageUrl = "Sora/Magic/MagicCure0.png", MethodName = "SendCureMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Cure), Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Cure to Sora's Magic", ImageUrl = "Sora/Magic/MagicCure1.png", MethodName = "SendCureMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Cura), Cost = Constants.Cost500, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Cura to Sora's Magic", ImageUrl = "Sora/Magic/MagicCure2.png", MethodName = "SendCureMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Curaga), Cost = Constants.Cost750, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Curaga to Sora's Magic", ImageUrl = "Sora/Magic/MagicCure3.png", MethodName = "SendCureMagicMessage" },
                        }
                },
                new ButtonTemplate
                {
                    Name = "Give/ Take Magnet Magic",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Give Magnet/ Magnera/ Magnega or Remove",
                    ImageUrl = "Sora/Magic/MagicMagnet1.png",
                    SubMethodParams = new List<ButtonTemplate>
                        {
                            new ButtonTemplate { Name = Constants.Take(Constants.Magnet), Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Magnet Element from Sora's Magic", ImageUrl = "Sora/Magic/MagicMagnet0.png", MethodName = "SendMagnetMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Magnet), Cost = Constants.Cost250, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Magnet to Sora's Magic", ImageUrl = "Sora/Magic/MagicMagnet1.png", MethodName = "SendMagnetMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Magnera), Cost = Constants.Cost400, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Magnera to Sora's Magic", ImageUrl = "Sora/Magic/MagicMagnet2.png", MethodName = "SendMagnetMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Magnega), Cost = Constants.Cost500, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Magnega to Sora's Magic", ImageUrl = "Sora/Magic/MagicMagnet3.png", MethodName = "SendMagnetMagicMessage" },
                        }
                },
                new ButtonTemplate
                {
                    Name = "Give/ Take Reflect Magic",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Give Reflect/ Reflera/ Reflega or Remove",
                    ImageUrl = "Sora/Magic/MagicReflect1.png",
                    SubMethodParams = new List<ButtonTemplate>
                        {
                            new ButtonTemplate { Name = Constants.Take(Constants.Reflect), Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Remove the Reflect Element from Sora's Magic", ImageUrl = "Sora/Magic/MagicReflect0.png", MethodName = "SendReflectMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Reflect), Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Set, Description = "Add Reflect to Sora's Magic", ImageUrl = "Sora/Magic/MagicReflect1.png", MethodName = "SendReflectMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Reflera), Cost = Constants.Cost500, Value = 2, ManipulationType = ManipulationType.Set, Description = "Add Reflera to Sora's Magic", ImageUrl = "Sora/Magic/MagicReflect2.png", MethodName = "SendReflectMagicMessage" },
                            new ButtonTemplate { Name = Constants.Give(Constants.Reflega), Cost = Constants.Cost750, Value = 3, ManipulationType = ManipulationType.Set, Description = "Add Reflega to Sora's Magic", ImageUrl = "Sora/Magic/MagicReflect3.png", MethodName = "SendReflectMagicMessage" },
                        }
                },

                #region Costs


                #region Spells

                new ButtonTemplate
                {
                    Name = "Change Fire Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Sora's Fire Magic Cost",
                    ImageUrl = "Sora/Magic/MagicFire1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Fire", ImageUrl = "Sora/Magic/MagicFire0.png", MethodName = "SendFireMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Fire", ImageUrl = "Sora/Magic/MagicFire1.png", MethodName = "SendFireMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Fire", ImageUrl = "Sora/Magic/MagicFire2.png", MethodName = "SendFireMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Fire", ImageUrl = "Sora/Magic/MagicFire3.png", MethodName = "SendFireMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Fire", ImageUrl = "Sora/Magic/MagicFire3.png", MethodName = "SendFireMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Fire", ImageUrl = "Sora/Magic/MagicFire3.png", MethodName = "SendFireMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Blizzard Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Sora's Blizzard Magic Cost",
                    ImageUrl = "Sora/Magic/MagicBlizzard1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Blizzard", ImageUrl = "Sora/Magic/MagicBlizzard0.png", MethodName = "SendBlizzardMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Blizzard", ImageUrl = "Sora/Magic/MagicBlizzard1.png", MethodName = "SendBlizzardMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Blizzard", ImageUrl = "Sora/Magic/MagicBlizzard2.png", MethodName = "SendBlizzardMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Blizzard", ImageUrl = "Sora/Magic/MagicBlizzard3.png", MethodName = "SendBlizzardMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Blizzard", ImageUrl = "Sora/Magic/MagicBlizzard3.png", MethodName = "SendBlizzardMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Blizzard", ImageUrl = "Sora/Magic/MagicBlizzard3.png", MethodName = "SendBlizzardMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Thunder Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Sora's Thunder Magic Cost",
                    ImageUrl = "Sora/Magic/MagicThunder1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Thunder", ImageUrl = "Sora/Magic/MagicThunder0.png", MethodName = "SendThunderMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Thunder", ImageUrl = "Sora/Magic/MagicThunder1.png", MethodName = "SendThunderMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Thunder", ImageUrl = "Sora/Magic/MagicThunder2.png", MethodName = "SendThunderMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Thunder", ImageUrl = "Sora/Magic/MagicThunder3.png", MethodName = "SendThunderMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Thunder", ImageUrl = "Sora/Magic/MagicThunder3.png", MethodName = "SendThunderMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Thunder", ImageUrl = "Sora/Magic/MagicThunder3.png", MethodName = "SendThunderMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Cure Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Sora's Cure Magic Cost",
                    ImageUrl = "Sora/Magic/MagicCure1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Cure", ImageUrl = "Sora/Magic/MagicCure0.png", MethodName = "SendCureMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Cure", ImageUrl = "Sora/Magic/MagicCure1.png", MethodName = "SendCureMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Cure", ImageUrl = "Sora/Magic/MagicCure2.png", MethodName = "SendCureMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Cure", ImageUrl = "Sora/Magic/MagicCure3.png", MethodName = "SendCureMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Cure", ImageUrl = "Sora/Magic/MagicCure3.png", MethodName = "SendCureMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Cure", ImageUrl = "Sora/Magic/MagicCure3.png", MethodName = "SendCureMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Magnet Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Sora's Magnet Magic Cost",
                    ImageUrl = "Sora/Magic/MagicMagnet1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Magnet", ImageUrl = "Sora/Magic/MagicMagnet0.png", MethodName = "SendMagnetMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Magnet", ImageUrl = "Sora/Magic/MagicMagnet1.png", MethodName = "SendMagnetMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Magnet", ImageUrl = "Sora/Magic/MagicMagnet2.png", MethodName = "SendMagnetMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Magnet", ImageUrl = "Sora/Magic/MagicMagnet3.png", MethodName = "SendMagnetMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Magnet", ImageUrl = "Sora/Magic/MagicMagnet3.png", MethodName = "SendMagnetMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Magnet", ImageUrl = "Sora/Magic/MagicMagnet3.png", MethodName = "SendMagnetMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Reflect Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Sora's Reflect Magic Cost",
                    ImageUrl = "Sora/Magic/MagicReflect1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Reflect", ImageUrl = "Sora/Magic/MagicReflect0.png", MethodName = "SendReflectMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Reflect", ImageUrl = "Sora/Magic/MagicReflect1.png", MethodName = "SendReflectMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Reflect", ImageUrl = "Sora/Magic/MagicReflect2.png", MethodName = "SendReflectMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Reflect", ImageUrl = "Sora/Magic/MagicReflect3.png", MethodName = "SendReflectMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Reflect", ImageUrl = "Sora/Magic/MagicReflect3.png", MethodName = "SendReflectMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Reflect", ImageUrl = "Sora/Magic/MagicReflect3.png", MethodName = "SendReflectMagicCostMessage" },
                    }
                },

                #endregion Spells

                #region Limits

                new ButtonTemplate
                {
                    Name = "Change Trinity Limit Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Sora's Trinity Limit Magic Cost",
                    ImageUrl = "Sora/Magic/MagicTrinityLimit1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Trinity Limit", ImageUrl = "Sora/Magic/MagicTrinityLimit0.png", MethodName = "SendTrinityLimitMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Trinity Limit", ImageUrl = "Sora/Magic/MagicTrinityLimit1.png", MethodName = "SendTrinityLimitMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Trinity Limit", ImageUrl = "Sora/Magic/MagicTrinityLimit2.png", MethodName = "SendTrinityLimitMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Trinity Limit", ImageUrl = "Sora/Magic/MagicTrinityLimit3.png", MethodName = "SendTrinityLimitMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Trinity Limit", ImageUrl = "Sora/Magic/MagicTrinityLimit3.png", MethodName = "SendTrinityLimitMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Trinity Limit", ImageUrl = "Sora/Magic/MagicTrinityLimit3.png", MethodName = "SendTrinityLimitMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Duck Flare Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Donald's Duck Flare Magic Cost",
                    ImageUrl = "Sora/Magic/MagicDuckFlare1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Duck Flare", ImageUrl = "Sora/Magic/MagicDuckFlare0.png", MethodName = "SendDuckFlareMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Duck Flare", ImageUrl = "Sora/Magic/MagicDuckFlare1.png", MethodName = "SendDuckFlareMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Duck Flare", ImageUrl = "Sora/Magic/MagicDuckFlare2.png", MethodName = "SendDuckFlareMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Duck Flare", ImageUrl = "Sora/Magic/MagicDuckFlare3.png", MethodName = "SendDuckFlareMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Duck Flare", ImageUrl = "Sora/Magic/MagicDuckFlare3.png", MethodName = "SendDuckFlareMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Duck Flare", ImageUrl = "Sora/Magic/MagicDuckFlare3.png", MethodName = "SendDuckFlareMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Comet Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Donald's Comet Magic Cost",
                    ImageUrl = "Sora/Magic/MagicComet1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Comet", ImageUrl = "Sora/Magic/MagicComet0.png", MethodName = "SendCometMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Comet", ImageUrl = "Sora/Magic/MagicComet1.png", MethodName = "SendCometMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Comet", ImageUrl = "Sora/Magic/MagicComet2.png", MethodName = "SendCometMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Comet", ImageUrl = "Sora/Magic/MagicComet3.png", MethodName = "SendCometMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Comet", ImageUrl = "Sora/Magic/MagicComet3.png", MethodName = "SendCometMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Comet", ImageUrl = "Sora/Magic/MagicComet3.png", MethodName = "SendCometMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change WhirliGoof Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Goofy's WhirliGoof Magic Cost",
                    ImageUrl = "Sora/Magic/MagicWhirliGoof1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast WhirliGoof", ImageUrl = "Sora/Magic/MagicWhirliGoof0.png", MethodName = "SendWhirliGoofMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast WhirliGoof", ImageUrl = "Sora/Magic/MagicWhirliGoof1.png", MethodName = "SendWhirliGoofMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast WhirliGoof", ImageUrl = "Sora/Magic/MagicWhirliGoof2.png", MethodName = "SendWhirliGoofMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast WhirliGoof", ImageUrl = "Sora/Magic/MagicWhirliGoof3.png", MethodName = "SendWhirliGoofMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast WhirliGoof", ImageUrl = "Sora/Magic/MagicWhirliGoof3.png", MethodName = "SendWhirliGoofMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast WhirliGoof", ImageUrl = "Sora/Magic/MagicWhirliGoof3.png", MethodName = "SendWhirliGoofMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Knocksmash Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Goofy's Knocksmash Magic Cost",
                    ImageUrl = "Sora/Magic/MagicKnocksmash1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Knocksmash", ImageUrl = "Sora/Magic/MagicKnocksmash0.png", MethodName = "SendKnocksmashMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Knocksmash", ImageUrl = "Sora/Magic/MagicKnocksmash1.png", MethodName = "SendKnocksmashMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Knocksmash", ImageUrl = "Sora/Magic/MagicKnocksmash2.png", MethodName = "SendKnocksmashMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Knocksmash", ImageUrl = "Sora/Magic/MagicKnocksmash3.png", MethodName = "SendKnocksmashMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Knocksmash", ImageUrl = "Sora/Magic/MagicKnocksmash3.png", MethodName = "SendKnocksmashMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Knocksmash", ImageUrl = "Sora/Magic/MagicKnocksmash3.png", MethodName = "SendKnocksmashMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Red Rocket Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Mulan's Red Rocket Magic Cost",
                    ImageUrl = "Sora/Magic/MagicRedRocket1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Red Rocket", ImageUrl = "Sora/Magic/MagicRedRocket0.png", MethodName = "SendRedRocketMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Red Rocket", ImageUrl = "Sora/Magic/MagicRedRocket1.png", MethodName = "SendRedRocketMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Red Rocket", ImageUrl = "Sora/Magic/MagicRedRocket2.png", MethodName = "SendRedRocketMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Red Rocket", ImageUrl = "Sora/Magic/MagicRedRocket3.png", MethodName = "SendRedRocketMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Red Rocket", ImageUrl = "Sora/Magic/MagicRedRocket3.png", MethodName = "SendRedRocketMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Red Rocket", ImageUrl = "Sora/Magic/MagicRedRocket3.png", MethodName = "SendRedRocketMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Twin Howl Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Beast's Twin Howl Magic Cost",
                    ImageUrl = "Sora/Magic/MagicTwinHowl1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Twin Howl", ImageUrl = "Sora/Magic/MagicTwinHowl0.png", MethodName = "SendTwinHowlMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Twin Howl", ImageUrl = "Sora/Magic/MagicTwinHowl1.png", MethodName = "SendTwinHowlMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Twin Howl", ImageUrl = "Sora/Magic/MagicTwinHowl2.png", MethodName = "SendTwinHowlMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Twin Howl", ImageUrl = "Sora/Magic/MagicTwinHowl3.png", MethodName = "SendTwinHowlMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Twin Howl", ImageUrl = "Sora/Magic/MagicTwinHowl3.png", MethodName = "SendTwinHowlMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Twin Howl", ImageUrl = "Sora/Magic/MagicTwinHowl3.png", MethodName = "SendTwinHowlMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Bushido Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Auron's Bushido Magic Cost",
                    ImageUrl = "Sora/Magic/MagicBushido1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Bushido", ImageUrl = "Sora/Magic/MagicBushido0.png", MethodName = "SendBushidoMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Bushido", ImageUrl = "Sora/Magic/MagicBushido1.png", MethodName = "SendBushidoMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Bushido", ImageUrl = "Sora/Magic/MagicBushido2.png", MethodName = "SendBushidoMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Bushido", ImageUrl = "Sora/Magic/MagicBushido3.png", MethodName = "SendBushidoMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Bushido", ImageUrl = "Sora/Magic/MagicBushido3.png", MethodName = "SendBushidoMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Bushido", ImageUrl = "Sora/Magic/MagicBushido3.png", MethodName = "SendBushidoMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Bluff Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Captain Jack Sparrow's Bluff Magic Cost",
                    ImageUrl = "Sora/Magic/MagicBluff1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Bluff", ImageUrl = "Sora/Magic/MagicBluff0.png", MethodName = "SendBluffMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Bluff", ImageUrl = "Sora/Magic/MagicBluff1.png", MethodName = "SendBluffMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Bluff", ImageUrl = "Sora/Magic/MagicBluff2.png", MethodName = "SendBluffMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Bluff", ImageUrl = "Sora/Magic/MagicBluff3.png", MethodName = "SendBluffMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Bluff", ImageUrl = "Sora/Magic/MagicBluff3.png", MethodName = "SendBluffMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Bluff", ImageUrl = "Sora/Magic/MagicBluff3.png", MethodName = "SendBluffMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Dance Call Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Jack Skellington's Dance Call Magic Cost",
                    ImageUrl = "Sora/Magic/MagicDanceCall1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast DanceCall", ImageUrl = "Sora/Magic/MagicDanceCall0.png", MethodName = "SendDanceCallMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast DanceCall", ImageUrl = "Sora/Magic/MagicDanceCall1.png", MethodName = "SendDanceCallMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast DanceCall", ImageUrl = "Sora/Magic/MagicDanceCall2.png", MethodName = "SendDanceCallMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast DanceCall", ImageUrl = "Sora/Magic/MagicDanceCall3.png", MethodName = "SendDanceCallMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast DanceCall", ImageUrl = "Sora/Magic/MagicDanceCall3.png", MethodName = "SendDanceCallMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast DanceCall", ImageUrl = "Sora/Magic/MagicDanceCall3.png", MethodName = "SendDanceCallMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Speedster Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Aladdin's Speedster Magic Cost",
                    ImageUrl = "Sora/Magic/MagicSpeedster1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Speedster", ImageUrl = "Sora/Magic/MagicSpeedster0.png", MethodName = "SendSpeedsterMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Speedster", ImageUrl = "Sora/Magic/MagicSpeedster1.png", MethodName = "SendSpeedsterMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Speedster", ImageUrl = "Sora/Magic/MagicSpeedster2.png", MethodName = "SendSpeedsterMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Speedster", ImageUrl = "Sora/Magic/MagicSpeedster3.png", MethodName = "SendSpeedsterMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Speedster", ImageUrl = "Sora/Magic/MagicSpeedster3.png", MethodName = "SendSpeedsterMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Speedster", ImageUrl = "Sora/Magic/MagicSpeedster3.png", MethodName = "SendSpeedsterMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Wildcat Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Simba's Wildcat Magic Cost",
                    ImageUrl = "Sora/Magic/MagicWildcat1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Wildcat", ImageUrl = "Sora/Magic/MagicWildcat0.png", MethodName = "SendWildcatMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Wildcat", ImageUrl = "Sora/Magic/MagicWildcat1.png", MethodName = "SendWildcatMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Wildcat", ImageUrl = "Sora/Magic/MagicWildcat2.png", MethodName = "SendWildcatMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Wildcat", ImageUrl = "Sora/Magic/MagicWildcat3.png", MethodName = "SendWildcatMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Wildcat", ImageUrl = "Sora/Magic/MagicWildcat3.png", MethodName = "SendWildcatMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Wildcat", ImageUrl = "Sora/Magic/MagicWildcat3.png", MethodName = "SendWildcatMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Setup Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Tron's Setup Magic Cost",
                    ImageUrl = "Sora/Magic/MagicSetup1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Setup", ImageUrl = "Sora/Magic/MagicSetup0.png", MethodName = "SendSetupMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Setup", ImageUrl = "Sora/Magic/MagicSetup1.png", MethodName = "SendSetupMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Setup", ImageUrl = "Sora/Magic/MagicSetup2.png", MethodName = "SendSetupMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Setup", ImageUrl = "Sora/Magic/MagicSetup3.png", MethodName = "SendSetupMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Setup", ImageUrl = "Sora/Magic/MagicSetup3.png", MethodName = "SendSetupMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Setup", ImageUrl = "Sora/Magic/MagicSetup3.png", MethodName = "SendSetupMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Session Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Riku's Session Magic Cost",
                    ImageUrl = "Sora/Magic/MagicSession1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Session", ImageUrl = "Sora/Magic/MagicSession0.png", MethodName = "SendSessionMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Session", ImageUrl = "Sora/Magic/MagicSession1.png", MethodName = "SendSessionMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Session", ImageUrl = "Sora/Magic/MagicSession2.png", MethodName = "SendSessionMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Session", ImageUrl = "Sora/Magic/MagicSession3.png", MethodName = "SendSessionMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Session", ImageUrl = "Sora/Magic/MagicSession3.png", MethodName = "SendSessionMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Session", ImageUrl = "Sora/Magic/MagicSession3.png", MethodName = "SendSessionMagicCostMessage" },
                    }
                },

                #endregion Limits

                #region Limit Form

                new ButtonTemplate
                {
                    Name = "Change Strike Raid Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Limit Form's Strike Raid Magic Cost",
                    ImageUrl = "Sora/Magic/MagicStrikeRaid1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast StrikeRaid", ImageUrl = "Sora/Magic/MagicStrikeRaid0.png", MethodName = "SendStrikeRaidMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast StrikeRaid", ImageUrl = "Sora/Magic/MagicStrikeRaid1.png", MethodName = "SendStrikeRaidMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast StrikeRaid", ImageUrl = "Sora/Magic/MagicStrikeRaid2.png", MethodName = "SendStrikeRaidMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast StrikeRaid", ImageUrl = "Sora/Magic/MagicStrikeRaid3.png", MethodName = "SendStrikeRaidMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast StrikeRaid", ImageUrl = "Sora/Magic/MagicStrikeRaid3.png", MethodName = "SendStrikeRaidMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast StrikeRaid", ImageUrl = "Sora/Magic/MagicStrikeRaid3.png", MethodName = "SendStrikeRaidMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Sonic Blade Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Limit Form's Sonic Blade Magic Cost",
                    ImageUrl = "Sora/Magic/MagicSonicBlade1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast SonicBlade", ImageUrl = "Sora/Magic/MagicSonicBlade0.png", MethodName = "SendSonicBladeMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast SonicBlade", ImageUrl = "Sora/Magic/MagicSonicBlade1.png", MethodName = "SendSonicBladeMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast SonicBlade", ImageUrl = "Sora/Magic/MagicSonicBlade2.png", MethodName = "SendSonicBladeMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast SonicBlade", ImageUrl = "Sora/Magic/MagicSonicBlade3.png", MethodName = "SendSonicBladeMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast SonicBlade", ImageUrl = "Sora/Magic/MagicSonicBlade3.png", MethodName = "SendSonicBladeMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast SonicBlade", ImageUrl = "Sora/Magic/MagicSonicBlade3.png", MethodName = "SendSonicBladeMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Ragnarok Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Limit Form's Ragnarok Magic Cost",
                    ImageUrl = "Sora/Magic/MagicRagnarok1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast Ragnarok", ImageUrl = "Sora/Magic/MagicRagnarok0.png", MethodName = "SendRagnarokMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast Ragnarok", ImageUrl = "Sora/Magic/MagicRagnarok1.png", MethodName = "SendRagnarokMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast Ragnarok", ImageUrl = "Sora/Magic/MagicRagnarok2.png", MethodName = "SendRagnarokMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast Ragnarok", ImageUrl = "Sora/Magic/MagicRagnarok3.png", MethodName = "SendRagnarokMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast Ragnarok", ImageUrl = "Sora/Magic/MagicRagnarok3.png", MethodName = "SendRagnarokMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast Ragnarok", ImageUrl = "Sora/Magic/MagicRagnarok3.png", MethodName = "SendRagnarokMagicCostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Ars Arcanum Magic Cost",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Magic,
                    Cost = 0,
                    Description = "Update Limit Form's Ars Arcanum Magic Cost",
                    ImageUrl = "Sora/Magic/MagicArsArcanum1.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No MP Cost", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Costs no MP to cast ArsArcanum", ImageUrl = "Sora/Magic/MagicArsArcanum0.png", MethodName = "SendArsArcanumMagicCostMessage" },
                        new ButtonTemplate { Name = "1 MP Cost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Set, Description = "Costs 1 MP to cast ArsArcanum", ImageUrl = "Sora/Magic/MagicArsArcanum1.png", MethodName = "SendArsArcanumMagicCostMessage" },
                        new ButtonTemplate { Name = "10 MP Cost", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Set, Description = "Costs 10 MP to cast ArsArcanum", ImageUrl = "Sora/Magic/MagicArsArcanum2.png", MethodName = "SendArsArcanumMagicCostMessage" },
                        new ButtonTemplate { Name = "50 MP Cost", Cost = Constants.Cost400, Value = 50, ManipulationType = ManipulationType.Set, Description = "Costs 50 MP to cast ArsArcanum", ImageUrl = "Sora/Magic/MagicArsArcanum3.png", MethodName = "SendArsArcanumMagicCostMessage" },
                        new ButtonTemplate { Name = "100 MP Cost", Cost = Constants.Cost500, Value = 100, ManipulationType = ManipulationType.Set, Description = "Costs 100 MP to cast ArsArcanum", ImageUrl = "Sora/Magic/MagicArsArcanum3.png", MethodName = "SendArsArcanumMagicCostMessage" },
                        new ButtonTemplate { Name = "All MP Cost", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Costs All MP to cast ArsArcanum", ImageUrl = "Sora/Magic/MagicArsArcanum3.png", MethodName = "SendArsArcanumMagicCostMessage" },
                    }
                }

                #endregion Limit Form

                #endregion Costs
            };

            return options;
        }
    }
}