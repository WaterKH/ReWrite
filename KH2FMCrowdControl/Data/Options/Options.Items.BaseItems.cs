﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeBaseItemsOptions()
        {
            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = Constants.Potion,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Potions",
                    ImageUrl = "Items/Give/Items/Potion.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Potion", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Potion", ImageUrl = "Items/Give/Items/Potion.png", MethodName = "SendPotionMessage" },
                        new ButtonTemplate { Name = "Give 5 Potions", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Potions", ImageUrl = "Items/Give/Items/Potion.png", MethodName = "SendPotionMessage" },
                        new ButtonTemplate { Name = "Give 10 Potions", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Potions", ImageUrl = "Items/Give/Items/Potion.png", MethodName = "SendPotionMessage" },
                        new ButtonTemplate { Name = "Give 99 Potions", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Potions", ImageUrl = "Items/Give/Items/Potion.png", MethodName = "SendPotionMessage" },
                        new ButtonTemplate { Name = "Take 1 Potion", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Potion", ImageUrl = "Items/Take/Items/Potion.png", MethodName = "SendPotionMessage" },
                        new ButtonTemplate { Name = "Take 5 Potions", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Potions", ImageUrl = "Items/Take/Items/Potion.png", MethodName = "SendPotionMessage" },
                        new ButtonTemplate { Name = "Take 10 Potions", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Potions", ImageUrl = "Items/Take/Items/Potion.png", MethodName = "SendPotionMessage" },
                        new ButtonTemplate { Name = "Take 99 Potions", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Potions", ImageUrl = "Items/Take/Items/Potion.png", MethodName = "SendPotionMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.HiPotion,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Hi-Potions",
                    ImageUrl = "Items/Give/Items/Hi-Potion.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Hi-Potion", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Hi-Potion", ImageUrl = "Items/Give/Items/Hi-Potion.png", MethodName = "SendHiPotionMessage" },
                        new ButtonTemplate { Name = "Give 5 Hi-Potions", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Hi-Potions", ImageUrl = "Items/Give/Items/Hi-Potion.png", MethodName = "SendHiPotionMessage" },
                        new ButtonTemplate { Name = "Give 10 Hi-Potions", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Hi-Potions", ImageUrl = "Items/Give/Items/Hi-Potion.png", MethodName = "SendHiPotionMessage" },
                        new ButtonTemplate { Name = "Give 99 Hi-Potions", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Hi-Potions", ImageUrl = "Items/Give/Items/Hi-Potion.png", MethodName = "SendHiPotionMessage" },
                        new ButtonTemplate { Name = "Take 1 Hi-Potion", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Hi-Potion", ImageUrl = "Items/Take/Items/Hi-Potion.png", MethodName = "SendHiPotionMessage" },
                        new ButtonTemplate { Name = "Take 5 Hi-Potions", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Hi-Potions", ImageUrl = "Items/Take/Items/Hi-Potion.png", MethodName = "SendHiPotionMessage" },
                        new ButtonTemplate { Name = "Take 10 Hi-Potions", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Hi-Potions", ImageUrl = "Items/Take/Items/Hi-Potion.png", MethodName = "SendHiPotionMessage" },
                        new ButtonTemplate { Name = "Take 99 Hi-Potions", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Hi-Potions", ImageUrl = "Items/Take/Items/Hi-Potion.png", MethodName = "SendHiPotionMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.Ether,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Ethers",
                    ImageUrl = "Items/Give/Items/Ether.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Ether", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Ether", ImageUrl = "Items/Give/Items/Ether.png", MethodName = "SendEtherMessage" },
                        new ButtonTemplate { Name = "Give 5 Ethers", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Ethers", ImageUrl = "Items/Give/Items/Ether.png", MethodName = "SendEtherMessage" },
                        new ButtonTemplate { Name = "Give 10 Ethers", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Ethers", ImageUrl = "Items/Give/Items/Ether.png", MethodName = "SendEtherMessage" },
                        new ButtonTemplate { Name = "Give 99 Ethers", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Ethers", ImageUrl = "Items/Give/Items/Ether.png", MethodName = "SendEtherMessage" },
                        new ButtonTemplate { Name = "Take 1 Ether", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Ether", ImageUrl = "Items/Take/Items/Ether.png", MethodName = "SendEtherMessage" },
                        new ButtonTemplate { Name = "Take 5 Ethers", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Ethers", ImageUrl = "Items/Take/Items/Ether.png", MethodName = "SendEtherMessage" },
                        new ButtonTemplate { Name = "Take 10 Ethers", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Ethers", ImageUrl = "Items/Take/Items/Ether.png", MethodName = "SendEtherMessage" },
                        new ButtonTemplate { Name = "Take 99 Ethers", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Ethers", ImageUrl = "Items/Take/Items/Ether.png", MethodName = "SendEtherMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.Elixir,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Elixirs",
                    ImageUrl = "Items/Give/Items/Elixir.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Elixir", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Elixir", ImageUrl = "Items/Give/Items/Elixir.png", MethodName = "SendElixirMessage" },
                        new ButtonTemplate { Name = "Give 5 Elixirs", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Elixirs", ImageUrl = "Items/Give/Items/Elixir.png", MethodName = "SendElixirMessage" },
                        new ButtonTemplate { Name = "Give 10 Elixirs", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Elixirs", ImageUrl = "Items/Give/Items/Elixir.png", MethodName = "SendElixirMessage" },
                        new ButtonTemplate { Name = "Give 99 Elixirs", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Elixirs", ImageUrl = "Items/Give/Items/Elixir.png", MethodName = "SendElixirMessage" },
                        new ButtonTemplate { Name = "Take 1 Elixir", Cost = Constants.Cost400, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Elixir", ImageUrl = "Items/Take/Items/Elixir.png", MethodName = "SendElixirMessage" },
                        new ButtonTemplate { Name = "Take 5 Elixirs", Cost = Constants.Cost500, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Elixirs", ImageUrl = "Items/Take/Items/Elixir.png", MethodName = "SendElixirMessage" },
                        new ButtonTemplate { Name = "Take 10 Elixirs", Cost = Constants.Cost750, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Elixirs", ImageUrl = "Items/Take/Items/Elixir.png", MethodName = "SendElixirMessage" },
                        new ButtonTemplate { Name = "Take 99 Elixirs", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Elixirs", ImageUrl = "Items/Take/Items/Elixir.png", MethodName = "SendElixirMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.MegaPotion,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Mega-Potions",
                    ImageUrl = "Items/Give/Items/Mega-Potion.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Mega-Potion", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Mega-Potion", ImageUrl = "Items/Give/Items/Mega-Potion.png", MethodName = "SendMegaPotionMessage" },
                        new ButtonTemplate { Name = "Give 5 Mega-Potions", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Mega-Potions", ImageUrl = "Items/Give/Items/Mega-Potion.png", MethodName = "SendMegaPotionMessage" },
                        new ButtonTemplate { Name = "Give 10 Mega-Potions", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Mega-Potions", ImageUrl = "Items/Give/Items/Mega-Potion.png", MethodName = "SendMegaPotionMessage" },
                        new ButtonTemplate { Name = "Give 99 Mega-Potions", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Mega-Potions", ImageUrl = "Items/Give/Items/Mega-Potion.png", MethodName = "SendMegaPotionMessage" },
                        new ButtonTemplate { Name = "Take 1 Mega-Potion", Cost = Constants.Cost400, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Mega-Potion", ImageUrl = "Items/Take/Items/Mega-Potion.png", MethodName = "SendMegaPotionMessage" },
                        new ButtonTemplate { Name = "Take 5 Mega-Potions", Cost = Constants.Cost500, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Mega-Potions", ImageUrl = "Items/Take/Items/Mega-Potion.png", MethodName = "SendMegaPotionMessage" },
                        new ButtonTemplate { Name = "Take 10 Mega-Potions", Cost = Constants.Cost750, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Mega-Potions", ImageUrl = "Items/Take/Items/Mega-Potion.png", MethodName = "SendMegaPotionMessage" },
                        new ButtonTemplate { Name = "Take 99 Mega-Potions", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Mega-Potions", ImageUrl = "Items/Take/Items/Mega-Potion.png", MethodName = "SendMegaPotionMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.MegaEther,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Mega-Ethers",
                    ImageUrl = "Items/Give/Items/Mega-Ether.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Mega-Ether", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Mega-Ether", ImageUrl = "Items/Give/Items/Mega-Ether.png", MethodName = "SendMegaEtherMessage" },
                        new ButtonTemplate { Name = "Give 5 Mega-Ethers", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Mega-Ethers", ImageUrl = "Items/Give/Items/Mega-Ether.png", MethodName = "SendMegaEtherMessage" },
                        new ButtonTemplate { Name = "Give 10 Mega-Ethers", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Mega-Ethers", ImageUrl = "Items/Give/Items/Mega-Ether.png", MethodName = "SendMegaEtherMessage" },
                        new ButtonTemplate { Name = "Give 99 Mega-Ethers", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Mega-Ethers", ImageUrl = "Items/Give/Items/Mega-Ether.png", MethodName = "SendMegaEtherMessage" },
                        new ButtonTemplate { Name = "Take 1 Mega-Ether", Cost = Constants.Cost400, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Mega-Ether", ImageUrl = "Items/Take/Items/Mega-Ether.png", MethodName = "SendMegaEtherMessage" },
                        new ButtonTemplate { Name = "Take 5 Mega-Ethers", Cost = Constants.Cost500, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Mega-Ethers", ImageUrl = "Items/Take/Items/Mega-Ether.png", MethodName = "SendMegaEtherMessage" },
                        new ButtonTemplate { Name = "Take 10 Mega-Ethers", Cost = Constants.Cost750, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Mega-Ethers", ImageUrl = "Items/Take/Items/Mega-Ether.png", MethodName = "SendMegaEtherMessage" },
                        new ButtonTemplate { Name = "Take 99 Mega-Ethers", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Mega-Ethers", ImageUrl = "Items/Take/Items/Mega-Ether.png", MethodName = "SendMegaEtherMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.Megalixir,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Megalixirs",
                    ImageUrl = "Items/Give/Items/Megalixir.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Megalixir", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Megalixir", ImageUrl = "Items/Give/Items/Megalixir.png", MethodName = "SendMegaElixirMessage" },
                        new ButtonTemplate { Name = "Give 5 Megalixirs", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Megalixirs", ImageUrl = "Items/Give/Items/Megalixir.png", MethodName = "SendMegaElixirMessage" },
                        new ButtonTemplate { Name = "Give 10 Megalixirs", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Megalixirs", ImageUrl = "Items/Give/Items/Megalixir.png", MethodName = "SendMegaElixirMessage" },
                        new ButtonTemplate { Name = "Give 99 Megalixirs", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Megalixirs", ImageUrl = "Items/Give/Items/Megalixir.png", MethodName = "SendMegaElixirMessage" },
                        new ButtonTemplate { Name = "Take 1 Megalixir", Cost = Constants.Cost400, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Megalixir", ImageUrl = "Items/Take/Items/Megalixir.png", MethodName = "SendMegaElixirMessage" },
                        new ButtonTemplate { Name = "Take 5 Megalixirs", Cost = Constants.Cost500, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Megalixirs", ImageUrl = "Items/Take/Items/Megalixir.png", MethodName = "SendMegaElixirMessage" },
                        new ButtonTemplate { Name = "Take 10 Megalixirs", Cost = Constants.Cost750, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Megalixirs", ImageUrl = "Items/Take/Items/Megalixir.png", MethodName = "SendMegaElixirMessage" },
                        new ButtonTemplate { Name = "Take 99 Megalixirs", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Megalixirs", ImageUrl = "Items/Take/Items/Megalixir.png", MethodName = "SendMegaElixirMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.Tent,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Tents",
                    ImageUrl = "Items/Give/Items/Tent.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Tent", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Tent", ImageUrl = "Items/Give/Items/Tent.png", MethodName = "SendTentMessage" },
                        new ButtonTemplate { Name = "Give 5 Tents", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Tents", ImageUrl = "Items/Give/Items/Tent.png", MethodName = "SendTentMessage" },
                        new ButtonTemplate { Name = "Give 10 Tents", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Tents", ImageUrl = "Items/Give/Items/Tent.png", MethodName = "SendTentMessage" },
                        new ButtonTemplate { Name = "Give 99 Tents", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Tents", ImageUrl = "Items/Give/Items/Tent.png", MethodName = "SendTentMessage" },
                        new ButtonTemplate { Name = "Take 1 Tent", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Tent", ImageUrl = "Items/Take/Items/Tent.png", MethodName = "SendTentMessage" },
                        new ButtonTemplate { Name = "Take 5 Tents", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Tents", ImageUrl = "Items/Take/Items/Tent.png", MethodName = "SendTentMessage" },
                        new ButtonTemplate { Name = "Take 10 Tents", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Tents", ImageUrl = "Items/Take/Items/Tent.png", MethodName = "SendTentMessage" },
                        new ButtonTemplate { Name = "Take 99 Tents", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Tents", ImageUrl = "Items/Take/Items/Tent.png", MethodName = "SendTentMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.DriveRecovery,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Drive Recoveries",
                    ImageUrl = "Items/Give/Items/Drive_Recovery.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Drive Recovery", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Drive Recovery", ImageUrl = "Items/Give/Items/Drive_Recovery.png", MethodName = "SendDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Give 5 Drive Recoveries", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Drive Recoveries", ImageUrl = "Items/Give/Items/Drive_Recovery.png", MethodName = "SendDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Give 10 Drive Recoveries", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Drive Recoveries", ImageUrl = "Items/Give/Items/Drive_Recovery.png", MethodName = "SendDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Give 99 Drive Recoveries", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Drive Recoveries", ImageUrl = "Items/Give/Items/Drive_Recovery.png", MethodName = "SendDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Take 1 Drive Recovery", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Drive Recovery", ImageUrl = "Items/Take/Items/Drive_Recovery.png", MethodName = "SendDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Take 5 Drive Recoveries", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Drive Recoveries", ImageUrl = "Items/Take/Items/Drive_Recovery.png", MethodName = "SendDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Take 10 Drive Recoveries", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Drive Recoveries", ImageUrl = "Items/Take/Items/Drive_Recovery.png", MethodName = "SendDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Take 99 Drive Recoveries", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Drive Recoveries", ImageUrl = "Items/Take/Items/Drive_Recovery.png", MethodName = "SendDriveRecoveryMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.HighDriveRecovery,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take High Drive Recoveries",
                    ImageUrl = "Items/Give/Items/High_Drive_Recovery.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 High Drive Recovery", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 High Drive Recovery", ImageUrl = "Items/Give/Items/High_Drive_Recovery.png", MethodName = "SendHighDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Give 5 High Drive Recoveries", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 High Drive Recoveries", ImageUrl = "Items/Give/Items/High_Drive_Recovery.png", MethodName = "SendHighDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Give 10 High Drive Recoveries", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 High Drive Recoveries", ImageUrl = "Items/Give/Items/High_Drive_Recovery.png", MethodName = "SendHighDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Give 99 High Drive Recoveries", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 High Drive Recoveries", ImageUrl = "Items/Give/Items/High_Drive_Recovery.png", MethodName = "SendHighDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Take 1 High Drive Recovery", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 High Drive Recovery", ImageUrl = "Items/Take/Items/High_Drive_Recovery.png", MethodName = "SendHighDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Take 5 High Drive Recoveries", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 High Drive Recoveries", ImageUrl = "Items/Take/Items/High_Drive_Recovery.png", MethodName = "SendHighDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Take 10 High Drive Recoveries", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 High Drive Recoveries", ImageUrl = "Items/Take/Items/High_Drive_Recovery.png", MethodName = "SendHighDriveRecoveryMessage" },
                        new ButtonTemplate { Name = "Take 99 High Drive Recoveries", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 High Drive Recoveries", ImageUrl = "Items/Take/Items/High_Drive_Recovery.png", MethodName = "SendHighDriveRecoveryMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.PowerBoost,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Power Boosts",
                    ImageUrl = "Items/Give/Items/Power_Boost.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Power Boost", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Power Boost", ImageUrl = "Items/Give/Items/Power_Boost.png", MethodName = "SendPowerBoostMessage" },
                        new ButtonTemplate { Name = "Give 5 Power Boosts", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Power Boosts", ImageUrl = "Items/Give/Items/Power_Boost.png", MethodName = "SendPowerBoostMessage" },
                        new ButtonTemplate { Name = "Give 10 Power Boosts", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Power Boosts", ImageUrl = "Items/Give/Items/Power_Boost.png", MethodName = "SendPowerBoostMessage" },
                        new ButtonTemplate { Name = "Give 99 Power Boosts", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Power Boosts", ImageUrl = "Items/Give/Items/Power_Boost.png", MethodName = "SendPowerBoostMessage" },
                        new ButtonTemplate { Name = "Take 1 Power Boost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Power Boost", ImageUrl = "Items/Take/Items/Power_Boost.png", MethodName = "SendPowerBoostMessage" },
                        new ButtonTemplate { Name = "Take 5 Power Boosts", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Power Boosts", ImageUrl = "Items/Take/Items/Power_Boost.png", MethodName = "SendPowerBoostMessage" },
                        new ButtonTemplate { Name = "Take 10 Power Boosts", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Power Boosts", ImageUrl = "Items/Take/Items/Power_Boost.png", MethodName = "SendPowerBoostMessage" },
                        new ButtonTemplate { Name = "Take 99 Power Boosts", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Power Boosts", ImageUrl = "Items/Take/Items/Power_Boost.png", MethodName = "SendPowerBoostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.MagicBoost,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Magic Boosts",
                    ImageUrl = "Items/Give/Items/Magic_Boost.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Magic Boost", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Magic Boost", ImageUrl = "Items/Give/Items/Magic_Boost.png", MethodName = "SendMagicBoostMessage" },
                        new ButtonTemplate { Name = "Give 5 Magic Boosts", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Magic Boosts", ImageUrl = "Items/Give/Items/Magic_Boost.png", MethodName = "SendMagicBoostMessage" },
                        new ButtonTemplate { Name = "Give 10 Magic Boosts", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Magic Boosts", ImageUrl = "Items/Give/Items/Magic_Boost.png", MethodName = "SendMagicBoostMessage" },
                        new ButtonTemplate { Name = "Give 99 Magic Boosts", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Magic Boosts", ImageUrl = "Items/Give/Items/Magic_Boost.png", MethodName = "SendMagicBoostMessage" },
                        new ButtonTemplate { Name = "Take 1 Magic Boost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Magic Boost", ImageUrl = "Items/Take/Items/Magic_Boost.png", MethodName = "SendMagicBoostMessage" },
                        new ButtonTemplate { Name = "Take 5 Magic Boosts", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Magic Boosts", ImageUrl = "Items/Take/Items/Magic_Boost.png", MethodName = "SendMagicBoostMessage" },
                        new ButtonTemplate { Name = "Take 10 Magic Boosts", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Magic Boosts", ImageUrl = "Items/Take/Items/Magic_Boost.png", MethodName = "SendMagicBoostMessage" },
                        new ButtonTemplate { Name = "Take 99 Magic Boosts", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Magic Boosts", ImageUrl = "Items/Take/Items/Magic_Boost.png", MethodName = "SendMagicBoostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.DefenseBoost,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Defense Boosts",
                    ImageUrl = "Items/Give/Items/Defense_Boost.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 Defense Boost", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Defense Boost", ImageUrl = "Items/Give/Items/Defense_Boost.png", MethodName = "SendDefenseBoostMessage" },
                        new ButtonTemplate { Name = "Give 5 Defense Boosts", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Defense Boosts", ImageUrl = "Items/Give/Items/Defense_Boost.png", MethodName = "SendDefenseBoostMessage" },
                        new ButtonTemplate { Name = "Give 10 Defense Boosts", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Defense Boosts", ImageUrl = "Items/Give/Items/Defense_Boost.png", MethodName = "SendDefenseBoostMessage" },
                        new ButtonTemplate { Name = "Give 99 Defense Boosts", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Defense Boosts", ImageUrl = "Items/Give/Items/Defense_Boost.png", MethodName = "SendDefenseBoostMessage" },
                        new ButtonTemplate { Name = "Take 1 Defense Boost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Defense Boost", ImageUrl = "Items/Take/Items/Defense_Boost.png", MethodName = "SendDefenseBoostMessage" },
                        new ButtonTemplate { Name = "Take 5 Defense Boosts", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Defense Boosts", ImageUrl = "Items/Take/Items/Defense_Boost.png", MethodName = "SendDefenseBoostMessage" },
                        new ButtonTemplate { Name = "Take 10 Defense Boosts", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Defense Boosts", ImageUrl = "Items/Take/Items/Defense_Boost.png", MethodName = "SendDefenseBoostMessage" },
                        new ButtonTemplate { Name = "Take 99 Defense Boosts", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Defense Boosts", ImageUrl = "Items/Take/Items/Defense_Boost.png", MethodName = "SendDefenseBoostMessage" },
                    }
                },
                new ButtonTemplate
                {
                    Name = Constants.APBoost,
                    Category = GroupType.Items,
                    SubCategory = SubGroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take AP Boosts",
                    ImageUrl = "Items/Give/Items/AP_Boost.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Give 1 AP Boost", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 AP Boost", ImageUrl = "Items/Give/Items/AP_Boost.png", MethodName = "SendAPBoostMessage" },
                        new ButtonTemplate { Name = "Give 5 AP Boosts", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 AP Boosts", ImageUrl = "Items/Give/Items/AP_Boost.png", MethodName = "SendAPBoostMessage" },
                        new ButtonTemplate { Name = "Give 10 AP Boosts", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 AP Boosts", ImageUrl = "Items/Give/Items/AP_Boost.png", MethodName = "SendAPBoostMessage" },
                        new ButtonTemplate { Name = "Give 99 AP Boosts", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 AP Boosts", ImageUrl = "Items/Give/Items/AP_Boost.png", MethodName = "SendAPBoostMessage" },
                        new ButtonTemplate { Name = "Take 1 AP Boost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 AP Boost", ImageUrl = "Items/Take/Items/AP_Boost.png", MethodName = "SendAPBoostMessage" },
                        new ButtonTemplate { Name = "Take 5 AP Boosts", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 AP Boosts", ImageUrl = "Items/Take/Items/AP_Boost.png", MethodName = "SendAPBoostMessage" },
                        new ButtonTemplate { Name = "Take 10 AP Boosts", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 AP Boosts", ImageUrl = "Items/Take/Items/AP_Boost.png", MethodName = "SendAPBoostMessage" },
                        new ButtonTemplate { Name = "Take 99 AP Boosts", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 AP Boosts", ImageUrl = "Items/Take/Items/AP_Boost.png", MethodName = "SendAPBoostMessage" },
                    }
                }
            };

            return options;
        }
    }
}