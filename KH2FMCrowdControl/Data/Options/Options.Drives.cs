﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeDriveOptions()
        {
            var options = new List<ButtonTemplate>() {

                new ButtonTemplate
                {
                    Name = "Change Gauge",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Give or Take from Sora's Drive Counter",
                    ImageUrl = "Drives/Drive_Orb.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Set Drive Counter 0", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Take all of Sora's Drive Counters", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendCurrentDriveCounterMessage" },
                        new ButtonTemplate { Name = "Set Drive Counter 9", Cost = Constants.Cost500, Value = 9, ManipulationType = ManipulationType.Set, Description = "Give Sora 9 Drive Counters", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendCurrentDriveCounterMessage" },
                        new ButtonTemplate { Name = "Set Drive Counter Max", Cost = Constants.Cost750, Value = 255, ManipulationType = ManipulationType.Set, Description = "Give Sora 255 Drive Counters", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendCurrentDriveCounterMessage" },
                        //new ButtonTemplate { Name = "Add to Drive Counter", Cost = Constants.Cost250, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 to Sora's Drive Counters", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendCurrentDriveCounterMessage" },
                        //new ButtonTemplate { Name = "Subtract From Drive Counter", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 from Sora's Drive Counters", ImageUrl = "Drives/Limit_FoDrive_Orbrm_Orb.png", MethodName = "SendCurrentDriveCounterMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Max Gauge",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Give or Take from Sora's Max Drive Counter",
                    ImageUrl = "Drives/Drive_Orb.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Set Max Drive Counter 0", Cost = Constants.Cost500, Value = 0, ManipulationType = ManipulationType.Set, Description = "Take all of Sora's Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendMaxDriveCounterMessage" },
                        new ButtonTemplate { Name = "Set Max Drive Counter 9", Cost = Constants.Cost400, Value = 9, ManipulationType = ManipulationType.Set, Description = "Give Sora 9 Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendMaxDriveCounterMessage" },
                        new ButtonTemplate { Name = "Set Max Drive Counter Max", Cost = Constants.Cost500, Value = 255, ManipulationType = ManipulationType.Set, Description = "Give Sora 255 Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendMaxDriveCounterMessage" },
                        //new ButtonTemplate { Name = "Add to Max Drive Counter", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Add, Description = "Add 1 to Sora's Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendMaxDriveCounterMessage" },
                        //new ButtonTemplate { Name = "Subtract From Max Drive Counter", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Subtract 1 from Sora's Max Drive Counters", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendMaxDriveCounterMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Drive Timer",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Give or Take from Sora's Drive Timer",
                    ImageUrl = "Drives/Drive_Orb.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Set Drive Timer 0", Cost = Constants.Cost400, Value = 0, ManipulationType = ManipulationType.Set, Description = "Sets Drive Timer to 0", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendDriveTimeMessage" },
                        new ButtonTemplate { Name = "Set Drive Timer Max", Cost = Constants.Cost300, Value = 5000, ManipulationType = ManipulationType.Set, Description = "Sets Drive Timer to Current Max", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendDriveTimeMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Enable/ Disable Drive",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Enable or Disable Sora's Drive Forms",
                    ImageUrl = "Drives/Drive_Orb.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Disable Drives", Cost = Constants.Cost1000, Value = 1, ManipulationType = ManipulationType.Set, Description = "Disable Sora's Drive Forms", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendDisableDriveMessage" },
                        new ButtonTemplate { Name = "Enable Drives", Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Enable Sora's Drive Forms", ImageUrl = "Drives/Drive_Orb.png", MethodName = "SendDisableDriveMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Give/ Take Drive Form",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Give or Take Sora's Drive Forms",
                    ImageUrl = "Drives/Valor_Form_Orb.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = Constants.Give(Constants.ValorForm), Cost = Constants.Cost300, Value = 2, ManipulationType = ManipulationType.Add, Description = "Give Valor Form to Sora", ImageUrl = "Drives/Valor_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.ValorForm), Cost = Constants.Cost400, Value = 2, ManipulationType = ManipulationType.Subtract, Description = "Take Valor Form from Sora", ImageUrl = "Drives/Valor_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                        new ButtonTemplate { Name = Constants.Give(Constants.WisdomForm), Cost = Constants.Cost300, Value = 4, ManipulationType = ManipulationType.Add, Description = "Give Wisdom Form to Sora", ImageUrl = "Drives/Wisdom_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.WisdomForm), Cost = Constants.Cost400, Value = 4, ManipulationType = ManipulationType.Subtract, Description = "Take Wisdom Form from Sora", ImageUrl = "Drives/Wisdom_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                        new ButtonTemplate { Name = Constants.Give(Constants.LimitForm), Cost = Constants.Cost500, Value = 8, ManipulationType = ManipulationType.Add, Description = "Give Limit Form to Sora", ImageUrl = "Drives/Limit_Form_Orb.png", MethodName = "SendLimitMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.LimitForm), Cost = Constants.Cost750, Value = 8, ManipulationType = ManipulationType.Subtract, Description = "Take Limit Form from Sora", ImageUrl = "Drives/Limit_Form_Orb.png", MethodName = "SendLimitMessage" },
                        new ButtonTemplate { Name = Constants.Give(Constants.MasterForm), Cost = Constants.Cost400, Value = 16, ManipulationType = ManipulationType.Add, Description = "Give Master Form to Sora", ImageUrl = "Drives/Master_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.MasterForm), Cost = Constants.Cost500, Value = 16, ManipulationType = ManipulationType.Subtract, Description = "Take Master Form from Sora", ImageUrl = "Drives/Master_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                        new ButtonTemplate { Name = Constants.Give(Constants.FinalForm), Cost = Constants.Cost750, Value = 32, ManipulationType = ManipulationType.Add, Description = "Give Final Form to Sora", ImageUrl = "Drives/Final_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.FinalForm), Cost = Constants.Cost1000, Value = 32, ManipulationType = ManipulationType.Subtract, Description = "Take Final Form from Sora", ImageUrl = "Drives/Final_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                        new ButtonTemplate { Name = Constants.Give(Constants.Antiform), Cost = Constants.Cost750, Value = 64, ManipulationType = ManipulationType.Add, Description = "Give Anti Form to Sora", ImageUrl = "Drives/Anti_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                        new ButtonTemplate { Name = Constants.Take(Constants.Antiform), Cost = Constants.Cost750, Value = 64, ManipulationType = ManipulationType.Subtract, Description = "Take Anti Form from Sora", ImageUrl = "Drives/Anti_Form_Orb.png", MethodName = "SendValorWisdomMasterFinalAntiMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Activate Drive",
                    Category = GroupType.Drive,
                    Cost = 0,
                    Description = "Activate Drive",
                    ImageUrl = "Drives/Valor_Form_Orb.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        //new ButtonTemplate { Name = Constants.Normal, Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Revert Sora Back to Normal", ImageUrl = "Drives/Normal_Form.png", MethodName = "SendActivateFormMessage) },
                        new ButtonTemplate { Name = Constants.ValorForm, Cost = Constants.Cost400, Value = 6, ManipulationType = ManipulationType.Set, Description = "Activate Valor Form", ImageUrl = "Drives/Valor_Form_Orb.png", MethodName = "SendActivateFormMessage" },
                        new ButtonTemplate { Name = Constants.WisdomForm, Cost = Constants.Cost400, Value = 7, ManipulationType = ManipulationType.Set, Description = "Activate Wisdom Form", ImageUrl = "Drives/Wisdom_Form_Orb.png", MethodName = "SendActivateFormMessage" },
                        new ButtonTemplate { Name = Constants.LimitForm, Cost = Constants.Cost500, Value = 673, ManipulationType = ManipulationType.Set, Description = "Activate Limit Form", ImageUrl = "Drives/Limit_Form_Orb.png", MethodName = "SendActivateFormMessage" },
                        new ButtonTemplate { Name = Constants.MasterForm, Cost = Constants.Cost500, Value = 11, ManipulationType = ManipulationType.Set, Description = "Activate Master Form", ImageUrl = "Drives/Master_Form_Orb.png", MethodName = "SendActivateFormMessage" },
                        new ButtonTemplate { Name = Constants.FinalForm, Cost = Constants.Cost750, Value = 12, ManipulationType = ManipulationType.Set, Description = "Activate Final Form", ImageUrl = "Drives/Final_Form_Orb.png", MethodName = "SendActivateFormMessage" },
                        new ButtonTemplate { Name = Constants.Antiform, Cost = Constants.Cost1000, Value = 13, ManipulationType = ManipulationType.Set, Description = "Activate Antiform", ImageUrl = "Drives/Anti_Form_Orb.png", MethodName = "SendActivateFormMessage" },
                        //new ButtonTemplate { Name = Constants.Mickey, Cost = Constants.Cost750, Value = 7, ManipulationType = ManipulationType.Set, Description = "Activate Mickey?", ImageUrl = "Drives/Mickey_Form.png", MethodName = "SendActivateFormMessage" },
                    }
                }
            };

            return options;
        }
    }
}