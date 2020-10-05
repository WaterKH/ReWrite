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
        public async Task<List<KHButtonTemplate>> InitializeBaseItemsOptions()
        {
            var options = new List<KHButtonTemplate> {
                
                new KHButtonTemplate
                {
                    Name = Constants.Potion,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Potions",
                    ImageUrl = "Items/Potion.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Potion", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Potion", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPotionMessage) },
                            new KHButtonTemplate { Name = "Give 5 Potions", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Potions", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPotionMessage) },
                            new KHButtonTemplate { Name = "Give 10 Potions", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Potions", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPotionMessage) },
                            new KHButtonTemplate { Name = "Give 99 Potions", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Potions", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPotionMessage) },
                            new KHButtonTemplate { Name = "Take 1 Potion", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Potion", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPotionMessage) },
                            new KHButtonTemplate { Name = "Take 5 Potions", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Potions", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPotionMessage) },
                            new KHButtonTemplate { Name = "Take 10 Potions", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Potions", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPotionMessage) },
                            new KHButtonTemplate { Name = "Take 99 Potions", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Potions", ImageUrl = "Items/Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPotionMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.HiPotion,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Hi-Potions",
                    ImageUrl = "Items/Hi-Potion.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Hi-Potion", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Hi-Potion", ImageUrl = "Items/Hi-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHiPotionMessage) },
                            new KHButtonTemplate { Name = "Give 5 Hi-Potions", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Hi-Potions", ImageUrl = "Items/Hi-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHiPotionMessage) },
                            new KHButtonTemplate { Name = "Give 10 Hi-Potions", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Hi-Potions", ImageUrl = "Items/Hi-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHiPotionMessage) },
                            new KHButtonTemplate { Name = "Give 99 Hi-Potions", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Hi-Potions", ImageUrl = "Items/Hi-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHiPotionMessage) },
                            new KHButtonTemplate { Name = "Take 1 Hi-Potion", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Hi-Potion", ImageUrl = "Items/Hi-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHiPotionMessage) },
                            new KHButtonTemplate { Name = "Take 5 Hi-Potions", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Hi-Potions", ImageUrl = "Items/Hi-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHiPotionMessage) },
                            new KHButtonTemplate { Name = "Take 10 Hi-Potions", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Hi-Potions", ImageUrl = "Items/Hi-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHiPotionMessage) },
                            new KHButtonTemplate { Name = "Take 99 Hi-Potions", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Hi-Potions", ImageUrl = "Items/Hi-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHiPotionMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.Ether,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Ethers",
                    ImageUrl = "Items/Ether.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Ether", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Ether", ImageUrl = "Items/Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEtherMessage) },
                            new KHButtonTemplate { Name = "Give 5 Ethers", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Ethers", ImageUrl = "Items/Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEtherMessage) },
                            new KHButtonTemplate { Name = "Give 10 Ethers", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Ethers", ImageUrl = "Items/Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEtherMessage) },
                            new KHButtonTemplate { Name = "Give 99 Ethers", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Ethers", ImageUrl = "Items/Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEtherMessage) },
                            new KHButtonTemplate { Name = "Take 1 Ether", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Ether", ImageUrl = "Items/Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEtherMessage) },
                            new KHButtonTemplate { Name = "Take 5 Ethers", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Ethers", ImageUrl = "Items/Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEtherMessage) },
                            new KHButtonTemplate { Name = "Take 10 Ethers", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Ethers", ImageUrl = "Items/Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEtherMessage) },
                            new KHButtonTemplate { Name = "Take 99 Ethers", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Ethers", ImageUrl = "Items/Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendEtherMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.Elixir,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Elixirs",
                    ImageUrl = "Items/Elixir.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Elixir", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Elixir", ImageUrl = "Items/Elixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElixirMessage) },
                            new KHButtonTemplate { Name = "Give 5 Elixirs", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Elixirs", ImageUrl = "Items/Elixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElixirMessage) },
                            new KHButtonTemplate { Name = "Give 10 Elixirs", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Elixirs", ImageUrl = "Items/Elixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElixirMessage) },
                            new KHButtonTemplate { Name = "Give 99 Elixirs", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Elixirs", ImageUrl = "Items/Elixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElixirMessage) },
                            new KHButtonTemplate { Name = "Take 1 Elixir", Cost = Constants.Cost400, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Elixir", ImageUrl = "Items/Elixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElixirMessage) },
                            new KHButtonTemplate { Name = "Take 5 Elixirs", Cost = Constants.Cost500, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Elixirs", ImageUrl = "Items/Elixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElixirMessage) },
                            new KHButtonTemplate { Name = "Take 10 Elixirs", Cost = Constants.Cost750, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Elixirs", ImageUrl = "Items/Elixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElixirMessage) },
                            new KHButtonTemplate { Name = "Take 99 Elixirs", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Elixirs", ImageUrl = "Items/Elixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendElixirMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.MegaPotion,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Mega-Potions",
                    ImageUrl = "Items/Mega-Potion.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Mega-Potion", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Mega-Potion", ImageUrl = "Items/Mega-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaPotionMessage) },
                            new KHButtonTemplate { Name = "Give 5 Mega-Potions", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Mega-Potions", ImageUrl = "Items/Mega-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaPotionMessage) },
                            new KHButtonTemplate { Name = "Give 10 Mega-Potions", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Mega-Potions", ImageUrl = "Items/Mega-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaPotionMessage) },
                            new KHButtonTemplate { Name = "Give 99 Mega-Potions", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Mega-Potions", ImageUrl = "Items/Mega-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaPotionMessage) },
                            new KHButtonTemplate { Name = "Take 1 Mega-Potion", Cost = Constants.Cost400, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Mega-Potion", ImageUrl = "Items/Mega-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaPotionMessage) },
                            new KHButtonTemplate { Name = "Take 5 Mega-Potions", Cost = Constants.Cost500, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Mega-Potions", ImageUrl = "Items/Mega-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaPotionMessage) },
                            new KHButtonTemplate { Name = "Take 10 Mega-Potions", Cost = Constants.Cost750, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Mega-Potions", ImageUrl = "Items/Mega-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaPotionMessage) },
                            new KHButtonTemplate { Name = "Take 99 Mega-Potions", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Mega-Potions", ImageUrl = "Items/Mega-Potion.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaPotionMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.MegaEther,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Mega-Ethers",
                    ImageUrl = "Items/Mega-Ether.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Mega-Ether", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Mega-Ether", ImageUrl = "Items/Mega-Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaEtherMessage) },
                            new KHButtonTemplate { Name = "Give 5 Mega-Ethers", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Mega-Ethers", ImageUrl = "Items/Mega-Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaEtherMessage) },
                            new KHButtonTemplate { Name = "Give 10 Mega-Ethers", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Mega-Ethers", ImageUrl = "Items/Mega-Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaEtherMessage) },
                            new KHButtonTemplate { Name = "Give 99 Mega-Ethers", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Mega-Ethers", ImageUrl = "Items/Mega-Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaEtherMessage) },
                            new KHButtonTemplate { Name = "Take 1 Mega-Ether", Cost = Constants.Cost400, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Mega-Ether", ImageUrl = "Items/Mega-Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaEtherMessage) },
                            new KHButtonTemplate { Name = "Take 5 Mega-Ethers", Cost = Constants.Cost500, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Mega-Ethers", ImageUrl = "Items/Mega-Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaEtherMessage) },
                            new KHButtonTemplate { Name = "Take 10 Mega-Ethers", Cost = Constants.Cost750, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Mega-Ethers", ImageUrl = "Items/Mega-Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaEtherMessage) },
                            new KHButtonTemplate { Name = "Take 99 Mega-Ethers", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Mega-Ethers", ImageUrl = "Items/Mega-Ether.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaEtherMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.Megalixir,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Megalixirs",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Megalixir", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Megalixir", ImageUrl = "Items/Megalixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaElixirMessage) },
                            new KHButtonTemplate { Name = "Give 5 Megalixirs", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Megalixirs", ImageUrl = "Items/Megalixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaElixirMessage) },
                            new KHButtonTemplate { Name = "Give 10 Megalixirs", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Megalixirs", ImageUrl = "Items/Megalixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaElixirMessage) },
                            new KHButtonTemplate { Name = "Give 99 Megalixirs", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Megalixirs", ImageUrl = "Items/Megalixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaElixirMessage) },
                            new KHButtonTemplate { Name = "Take 1 Megalixir", Cost = Constants.Cost400, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Megalixir", ImageUrl = "Items/Megalixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaElixirMessage) },
                            new KHButtonTemplate { Name = "Take 5 Megalixirs", Cost = Constants.Cost500, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Megalixirs", ImageUrl = "Items/Megalixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaElixirMessage) },
                            new KHButtonTemplate { Name = "Take 10 Megalixirs", Cost = Constants.Cost750, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Megalixirs", ImageUrl = "Items/Megalixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaElixirMessage) },
                            new KHButtonTemplate { Name = "Take 99 Megalixirs", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Megalixirs", ImageUrl = "Items/Megalixir.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMegaElixirMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.Tent,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Tents",
                    ImageUrl = "Items/Tent.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Tent", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Tent", ImageUrl = "Items/Tent.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendTentMessage) },
                            new KHButtonTemplate { Name = "Give 5 Tents", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Tents", ImageUrl = "Items/Tent.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendTentMessage) },
                            new KHButtonTemplate { Name = "Give 10 Tents", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Tents", ImageUrl = "Items/Tent.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendTentMessage) },
                            new KHButtonTemplate { Name = "Give 99 Tents", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Tents", ImageUrl = "Items/Tent.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendTentMessage) },
                            new KHButtonTemplate { Name = "Take 1 Tent", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Tent", ImageUrl = "Items/Tent.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendTentMessage) },
                            new KHButtonTemplate { Name = "Take 5 Tents", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Tents", ImageUrl = "Items/Tent.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendTentMessage) },
                            new KHButtonTemplate { Name = "Take 10 Tents", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Tents", ImageUrl = "Items/Tent.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendTentMessage) },
                            new KHButtonTemplate { Name = "Take 99 Tents", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Tents", ImageUrl = "Items/Tent.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendTentMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.DriveRecovery,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Drive Recoveries",
                    ImageUrl = "Items/Drive_Recovery.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Drive Recovery", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Drive Recovery", ImageUrl = "Items/Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Give 5 Drive Recoveries", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Drive Recoveries", ImageUrl = "Items/Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Give 10 Drive Recoveries", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Drive Recoveries", ImageUrl = "Items/Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Give 99 Drive Recoveries", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Drive Recoveries", ImageUrl = "Items/Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Take 1 Drive Recovery", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Drive Recovery", ImageUrl = "Items/Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Take 5 Drive Recoveries", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Drive Recoveries", ImageUrl = "Items/Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Take 10 Drive Recoveries", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Drive Recoveries", ImageUrl = "Items/Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Take 99 Drive Recoveries", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Drive Recoveries", ImageUrl = "Items/Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDriveRecoveryMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.HighDriveRecovery,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take High Drive Recoveries",
                    ImageUrl = "Items/High_Drive_Recovery.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 High Drive Recovery", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 High Drive Recovery", ImageUrl = "Items/High_Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHighDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Give 5 High Drive Recoveries", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 High Drive Recoveries", ImageUrl = "Items/High_Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHighDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Give 10 High Drive Recoveries", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 High Drive Recoveries", ImageUrl = "Items/High_Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHighDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Give 99 High Drive Recoveries", Cost = Constants.Cost750, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 High Drive Recoveries", ImageUrl = "Items/High_Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHighDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Take 1 High Drive Recovery", Cost = Constants.Cost300, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 High Drive Recovery", ImageUrl = "Items/High_Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHighDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Take 5 High Drive Recoveries", Cost = Constants.Cost400, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 High Drive Recoveries", ImageUrl = "Items/High_Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHighDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Take 10 High Drive Recoveries", Cost = Constants.Cost500, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 High Drive Recoveries", ImageUrl = "Items/High_Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHighDriveRecoveryMessage) },
                            new KHButtonTemplate { Name = "Take 99 High Drive Recoveries", Cost = Constants.Cost1000, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 High Drive Recoveries", ImageUrl = "Items/High_Drive_Recovery.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendHighDriveRecoveryMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.PowerBoost,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Power Boosts",
                    ImageUrl = "Items/Power_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Power Boost", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Power Boost", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPowerBoostMessage) },
                            new KHButtonTemplate { Name = "Give 5 Power Boosts", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Power Boosts", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPowerBoostMessage) },
                            new KHButtonTemplate { Name = "Give 10 Power Boosts", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Power Boosts", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPowerBoostMessage) },
                            new KHButtonTemplate { Name = "Give 99 Power Boosts", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Power Boosts", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPowerBoostMessage) },
                            new KHButtonTemplate { Name = "Take 1 Power Boost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Power Boost", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPowerBoostMessage) },
                            new KHButtonTemplate { Name = "Take 5 Power Boosts", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Power Boosts", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPowerBoostMessage) },
                            new KHButtonTemplate { Name = "Take 10 Power Boosts", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Power Boosts", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPowerBoostMessage) },
                            new KHButtonTemplate { Name = "Take 99 Power Boosts", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Power Boosts", ImageUrl = "Items/Power_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendPowerBoostMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.MagicBoost,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Magic Boosts",
                    ImageUrl = "Items/Magic_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Magic Boost", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Magic Boost", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagicBoostMessage) },
                            new KHButtonTemplate { Name = "Give 5 Magic Boosts", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Magic Boosts", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagicBoostMessage) },
                            new KHButtonTemplate { Name = "Give 10 Magic Boosts", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Magic Boosts", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagicBoostMessage) },
                            new KHButtonTemplate { Name = "Give 99 Magic Boosts", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Magic Boosts", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagicBoostMessage) },
                            new KHButtonTemplate { Name = "Take 1 Magic Boost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Magic Boost", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagicBoostMessage) },
                            new KHButtonTemplate { Name = "Take 5 Magic Boosts", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Magic Boosts", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagicBoostMessage) },
                            new KHButtonTemplate { Name = "Take 10 Magic Boosts", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Magic Boosts", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagicBoostMessage) },
                            new KHButtonTemplate { Name = "Take 99 Magic Boosts", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Magic Boosts", ImageUrl = "Items/Magic_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendMagicBoostMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.DefenseBoost,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take Defense Boosts",
                    ImageUrl = "Items/Defense_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 Defense Boost", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 Defense Boost", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDefenseBoostMessage) },
                            new KHButtonTemplate { Name = "Give 5 Defense Boosts", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 Defense Boosts", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDefenseBoostMessage) },
                            new KHButtonTemplate { Name = "Give 10 Defense Boosts", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 Defense Boosts", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDefenseBoostMessage) },
                            new KHButtonTemplate { Name = "Give 99 Defense Boosts", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 Defense Boosts", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDefenseBoostMessage) },
                            new KHButtonTemplate { Name = "Take 1 Defense Boost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 Defense Boost", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDefenseBoostMessage) },
                            new KHButtonTemplate { Name = "Take 5 Defense Boosts", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 Defense Boosts", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDefenseBoostMessage) },
                            new KHButtonTemplate { Name = "Take 10 Defense Boosts", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 Defense Boosts", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDefenseBoostMessage) },
                            new KHButtonTemplate { Name = "Take 99 Defense Boosts", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 Defense Boosts", ImageUrl = "Items/Defense_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDefenseBoostMessage) },
                        }
                },
                new KHButtonTemplate
                {
                    Name = Constants.APBoost,
                    Category = GroupType.Items,
                    Cost = 0,
                    Description = "Give/ Take AP Boosts",
                    ImageUrl = "Items/AP_Boost.png",
                    SubMethodParams = new List<KHButtonTemplate>
                        {
                            new KHButtonTemplate { Name = "Give 1 AP Boost", Cost = Constants.Cost100, Value = 1, ManipulationType = ManipulationType.Add, Description = "Give Sora 1 AP Boost", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendAPBoostMessage) },
                            new KHButtonTemplate { Name = "Give 5 AP Boosts", Cost = Constants.Cost200, Value = 5, ManipulationType = ManipulationType.Add, Description = "Give Sora 5 AP Boosts", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendAPBoostMessage) },
                            new KHButtonTemplate { Name = "Give 10 AP Boosts", Cost = Constants.Cost300, Value = 10, ManipulationType = ManipulationType.Add, Description = "Give Sora 10 AP Boosts", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendAPBoostMessage) },
                            new KHButtonTemplate { Name = "Give 99 AP Boosts", Cost = Constants.Cost400, Value = 99, ManipulationType = ManipulationType.Add, Description = "Give Sora 99 AP Boosts", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendAPBoostMessage) },
                            new KHButtonTemplate { Name = "Take 1 AP Boost", Cost = Constants.Cost200, Value = 1, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 1 AP Boost", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendAPBoostMessage) },
                            new KHButtonTemplate { Name = "Take 5 AP Boosts", Cost = Constants.Cost300, Value = 5, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 5 AP Boosts", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendAPBoostMessage) },
                            new KHButtonTemplate { Name = "Take 10 AP Boosts", Cost = Constants.Cost400, Value = 10, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 10 AP Boosts", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendAPBoostMessage) },
                            new KHButtonTemplate { Name = "Take 99 AP Boosts", Cost = Constants.Cost500, Value = 99, ManipulationType = ManipulationType.Subtract, Description = "Take Sora 99 AP Boosts", ImageUrl = "Items/AP_Boost.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendAPBoostMessage) },
                        }
                }
            };

            return options;
        }
    }
}