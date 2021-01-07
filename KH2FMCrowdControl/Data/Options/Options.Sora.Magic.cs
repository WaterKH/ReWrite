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
                }
            };

            return options;
        }
    }
}