using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSoraStatsOptions()
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Level",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Current Level",
                    ImageUrl = "Sora/Stats/SetLV.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Level Zero", Cost = Constants.Cost2000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Level to 0", ImageUrl = "Sora/Stats/SetLV0.png", MethodName = "SendSoraLevelMessage" },
                        new ButtonTemplate { Name = "Level One", Cost = Constants.Cost1000, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Level to 1", ImageUrl = "Sora/Stats/SetLV1.png", MethodName = "SendSoraLevelMessage" },
                        new ButtonTemplate { Name = "Level 99", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Level to 99", ImageUrl = "Sora/Stats/SetLV99.png", MethodName = "SendSoraLevelMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change HP",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Current HP",
                    ImageUrl = "Sora/Stats/SetHP.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        // TODO Calculate our max HP and give max/ half of that
                        new ButtonTemplate { Name = "No HP", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to Zero", ImageUrl = "Sora/Stats/SetHP0.png", MethodName = "SendSoraCurrentHPMessage" },
                        new ButtonTemplate { Name = "One HP", Cost = Constants.Cost750, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to One", ImageUrl = "Sora/Stats/SetHP1.png", MethodName = "SendSoraCurrentHPMessage" },
                        new ButtonTemplate { Name = "Half HP", Cost = Constants.Cost500, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to Half", ImageUrl = "Sora/Stats/SetHPHalf.png", MethodName = "SendSoraCurrentHPMessage" },
                        new ButtonTemplate { Name = "Max HP", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current HP to Max", ImageUrl = "Sora/Stats/SetHPFull.png", MethodName = "SendSoraCurrentHPMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Max HP",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Max HP",
                    ImageUrl = "Sora/Stats/MaxHP.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Invulnerability", Cost = Constants.Cost2000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to Zero - Grants Invulnerability", ImageUrl = "Sora/Stats/MaxHP0.png", MethodName = "SendSoraMaxHPMessage" },
                        new ButtonTemplate { Name = "One Max HP", Cost = Constants.Cost2000, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to One", ImageUrl = "Sora/Stats/MaxHP1.png", MethodName = "SendSoraMaxHPMessage" },
                        new ButtonTemplate { Name = "Half Max HP", Cost = Constants.Cost500, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to Half", ImageUrl = "Sora/Stats/MaxHPHalf.png", MethodName = "SendSoraMaxHPMessage" },
                        new ButtonTemplate { Name = "Max Max HP", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max HP to Max", ImageUrl = "Sora/Stats/MaxHPMax.png", MethodName = "SendSoraMaxHPMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Health Timer [Pro Code]",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Current HP every 2 seconds",
                    ImageUrl = "Sora/Stats/SetHPpro.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Activate Timer", Cost = Constants.Cost2000, Value = "On", ManipulationType = ManipulationType.Set, Description = "Set Sora's Health to slowly drain", ImageUrl = "Sora/Stats/SetHPpro.png", MethodName = "SendSoraHealthTimerMessage" },
                        new ButtonTemplate { Name = "Deactivate Timer", Cost = Constants.Cost750, Value = "Off", ManipulationType = ManipulationType.Set, Description = "Set Sora's Health to Normal", ImageUrl = "Sora/Stats/SetHPhalf.png", MethodName = "SendSoraHealthTimerMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Magic",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Current Magic",
                    ImageUrl = "Sora/Stats/SetMP.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "No Magic", Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Magic to Zero", ImageUrl = "Sora/Stats/SetMP0.png", MethodName = "SendSoraCurrentMagicMessage" },
                        new ButtonTemplate { Name = "One Magic", Cost = Constants.Cost500, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Magic to One", ImageUrl = "Sora/Stats/SetMP1.png", MethodName = "SendSoraCurrentMagicMessage" },
                        new ButtonTemplate { Name = "Half Magic", Cost = Constants.Cost250, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Magic to Half", ImageUrl = "Sora/Stats/SetMPHalf.png", MethodName = "SendSoraCurrentMagicMessage" },
                        new ButtonTemplate { Name = "Max Magic", Cost = Constants.Cost300, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Current Magic to Max", ImageUrl = "Sora/Stats/SetMPMax.png", MethodName = "SendSoraCurrentMagicMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Max Magic",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Max Magic",
                    ImageUrl = "Sora/Stats/MaxMP.png",
                    SubMethodParams = new List<ButtonTemplate>
                        {
                            new ButtonTemplate { Name = "No Max Magic", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max Magic to Zero", ImageUrl = "Sora/Stats/MaxMP0.png", MethodName = "SendSoraMaxMagicMessage" },
                            new ButtonTemplate { Name = "One Max Magic", Cost = Constants.Cost1000, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max Magic to One", ImageUrl = "Sora/Stats/MaxMP1.png", MethodName = "SendSoraMaxMagicMessage" },
                            new ButtonTemplate { Name = "Half Max Magic", Cost = Constants.Cost500, Value = 128, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max Magic to Half", ImageUrl = "Sora/Stats/MaxMPHalf.png", MethodName = "SendSoraMaxMagicMessage" },
                            new ButtonTemplate { Name = "Max Max Magic", Cost = Constants.Cost500, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Max Magic to Max", ImageUrl = "Sora/Stats/MaxMPMax.png", MethodName = "SendSoraMaxMagicMessage" },
                        }
                },
                new ButtonTemplate
                {
                    Name = "Magic Timer [Pro Code]",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Current Magic every 2 seconds",
                    ImageUrl = "Sora/Stats/SetMPpro.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Activate Timer", Cost = Constants.Cost2000, Value = "On", ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic to slowly drain", ImageUrl = "Sora/Stats/SetMPpro.png", MethodName = "SendSoraMagicTimerMessage" },
                        new ButtonTemplate { Name = "Deactivate Timer", Cost = Constants.Cost750, Value = "Off", ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic to Normal", ImageUrl = "Sora/Stats/SetMP1.png", MethodName = "SendSoraMagicTimerMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Recharge Magic",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "(Note: May only work when currently out of magic)",
                    ImageUrl = "Sora/Stats/SetMP0.png",
                    SubMethodParams = new List<ButtonTemplate>
                        {
                            new ButtonTemplate { Name = "Instant Timer Refill", Cost = Constants.Cost300, Value = 0, ManipulationType = ManipulationType.Set, Description = "Restore Sora's Magic Bar", ImageUrl = "Sora/Stats/SetMP.png", MethodName = "SendSoraRechargeMagicMessage" },
                            new ButtonTemplate { Name = "Max Out Timer", Cost = Constants.Cost500, Value = 3000, ManipulationType = ManipulationType.Set, Description = "Fill the Timer Back To Full", ImageUrl = "Sora/Stats/SetMP0.png", MethodName = "SendSoraRechargeMagicMessage" },
                            new ButtonTemplate { Name = "Fill Half Timer", Cost = Constants.Cost400, Value = 1500, ManipulationType = ManipulationType.Set, Description = "Fill the Timer to Half-way", ImageUrl = "Sora/Stats/MPrecHalf.png", MethodName = "SendSoraRechargeMagicMessage" },
                        }
                },
                new ButtonTemplate
                {
                    Name = "Change Strength Stat",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Strength Stat",
                    ImageUrl = "Sora/Stats/SetSTR.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {                            
                        new ButtonTemplate { Name = "Normal Strength Stat", Cost = Constants.Cost500, Value = 1, ManipulationType = ManipulationType.Add, Description = "Revert Sora's Strength to Normal", ImageUrl = "Sora/Stats/SetSTR.png", MethodName = "SendSoraStrengthStatMessage" },
                        new ButtonTemplate { Name = "Strength Stat Zero", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Strength to 0", ImageUrl = "Sora/Stats/SetSTRdown.png", MethodName = "SendSoraStrengthStatMessage" },
                        new ButtonTemplate { Name = "Max Strength Stat", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Strength to Max", ImageUrl = "Sora/Stats/SetSTRup.png", MethodName = "SendSoraStrengthStatMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Magic Stat",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Magic Stat",
                    ImageUrl = "Sora/Stats/SetMAG.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Normal Magic Stat", Cost = Constants.Cost500, Value = 1, ManipulationType = ManipulationType.Add, Description = "Revert Sora's Magic to Normal", ImageUrl = "Sora/Stats/SetMAG.png", MethodName = "SendSoraMagicStatMessage" },
                        new ButtonTemplate { Name = "Zero Magic Stat", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic to 0", ImageUrl = "Sora/Stats/SetMAGdown.png", MethodName = "SendSoraMagicStatMessage" },
                        new ButtonTemplate { Name = "Max Magic Stat", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic to Max", ImageUrl = "Sora/Stats/SetMAGup.png", MethodName = "SendSoraMagicStatMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Defense Stat",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Defense Stat",
                    ImageUrl = "Sora/Stats/SetDEF.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Normal Defense Stat", Cost = Constants.Cost500, Value = 1, ManipulationType = ManipulationType.Add, Description = "Revert Sora's Defense to Normal", ImageUrl = "Sora/Stats/SetDEF.png", MethodName = "SendSoraDefenseStatMessage" },
                        new ButtonTemplate { Name = "Zero Defense Stat", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Defense to 0", ImageUrl = "Sora/Stats/SetDEFdown.png", MethodName = "SendSoraDefenseStatMessage" },
                        new ButtonTemplate { Name = "Max Defense Stat", Cost = Constants.Cost1000, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Defense to Max", ImageUrl = "Sora/Stats/SetDEFup.png", MethodName = "SendSoraDefenseStatMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change AP",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's AP Boosts",
                    ImageUrl = "Sora/Stats/SetAP.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "AP Boosts Zero", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's AP to 0", ImageUrl = "Sora/Stats/SetAP0.png", MethodName = "SendSoraAPBoostMessage" },
                        new ButtonTemplate { Name = "Max AP Boosts", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's AP to Max", ImageUrl = "Sora/Stats/SetAPup.png", MethodName = "SendSoraAPBoostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Strength Boosts",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Strength Boosts",
                    ImageUrl = "Sora/Stats/SetSTR.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Strength Boosts Zero", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Strength Boost to 0", ImageUrl = "Sora/Stats/SetSTR0.png", MethodName = "SendSoraStrengthBoostMessage" },
                        new ButtonTemplate { Name = "Max Strength Boosts", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Strength Boost to Max", ImageUrl = "Sora/Stats/SetSTRup.png", MethodName = "SendSoraStrengthBoostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Magic Boosts",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Magic Boosts",
                    ImageUrl = "Sora/Stats/SetMAG.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Magic Boosts Zero", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic Boost to 0", ImageUrl = "Sora/Stats/SetMAG0.png", MethodName = "SendSoraMagicBoostMessage" },
                        new ButtonTemplate { Name = "Max Magic Boosts", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Magic Boost to Max", ImageUrl = "Sora/Stats/SetMAGup.png", MethodName = "SendSoraMagicBoostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Defense Boosts",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Update Sora's Defense Boosts",
                    ImageUrl = "Sora/Stats/SetDEF.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Defense Boosts Zero", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Sora's Defense Boost to 0", ImageUrl = "Sora/Stats/SetDEF0.png", MethodName = "SendSoraDefenseBoostMessage" },
                        new ButtonTemplate { Name = "Max Defense Boosts", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Set Sora's Defense Boost to Max", ImageUrl = "Sora/Stats/SetDEFup.png", MethodName = "SendSoraDefenseBoostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Sora's Speed",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Stats,
                    Cost = 0,
                    Description = "Increase/ Decrease Sora's Speed",
                    ImageUrl = "Sora/Stats/SetSPEED.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Slow Down", Cost = Constants.Cost400, Value = 1086324736, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Slow", ImageUrl = "Sora/Stats/SetSPEEDdown.png", MethodName = "SendSoraSpeedMessage" },
                        new ButtonTemplate { Name = "Slow Down x2", Cost = Constants.Cost500, Value = 1078984704, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Slow x2", ImageUrl = "Sora/Stats/SetSPEEDdown1.png", MethodName = "SendSoraSpeedMessage" },
                        new ButtonTemplate { Name = "Slow Down x3", Cost = Constants.Cost1000, Value = 1073741824, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Slow x3", ImageUrl = "Sora/Stats/SetSPEEDdown2.png", MethodName = "SendSoraSpeedMessage" },
                        new ButtonTemplate { Name = "Revert to Normal", Cost = Constants.Cost500, Value = 1090519040, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Normal", ImageUrl = "Sora/Stats/SetSPEEDnormal.png", MethodName = "SendSoraSpeedMessage" },
                        new ButtonTemplate { Name = "Speed Up", Cost = Constants.Cost400, Value = 1103101952, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Fast", ImageUrl = "Sora/Stats/SetSPEEDup.png", MethodName = "SendSoraSpeedMessage" },
                        new ButtonTemplate { Name = "Speed Up x2", Cost = Constants.Cost500, Value = 1112539136, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Fast x2", ImageUrl = "Sora/Stats/SetSPEEDup1.png", MethodName = "SendSoraSpeedMessage" },
                        new ButtonTemplate { Name = "Speed Up x3", Cost = Constants.Cost1000, Value = 1140850688, ManipulationType = ManipulationType.Set, Description = "Set Sora's Speed to Fast x3", ImageUrl = "Sora/Stats/SetSPEEDup2.png", MethodName = "SendSoraSpeedMessage" },
                    }
                },
            };

            return options;
        }
    }
}