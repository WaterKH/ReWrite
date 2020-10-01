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
        public async Task<List<KHButtonTemplate>> InitializeDonaldItemsOptions()
        {
            var items = new List<KHButtonTemplate> {

                new KHButtonTemplate
                {
                    Name = "Change Item Slots",
                    Category = GroupType.Donald,
                    Cost = 0,
                    Description = "Update Donald's Item Slots",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = "No Slots", Cost = 450, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 0", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "1 Slot", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 1", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "2 Slot", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 2", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "3 Slot", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 3", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "4 Slot", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 4", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "5 Slot", Cost = 450, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 5", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "6 Slot", Cost = 450, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 6", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "7 Slot", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 7", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                        new KHButtonTemplate { Name = "8 Slot", Cost = 650, Value = 3, ManipulationType = ManipulationType.Set, Description = "Set Donald's Item Slots to 8", ImageUrl = "Armor/Abas_Chain.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlotsMessage) },
                    }
                },
                new KHButtonTemplate
                {
                    Name = "Change Item Slot 1",
                    Category = GroupType.Donald,
                    Cost = 0,
                    Description = "Update Donald's Item Slot 1",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = Constants.None, Cost = 10, Value = 0, ManipulationType = ManipulationType.Set, Description = "Give Elven Bandana", ImageUrl = "Armor/Elven_Bandana.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot1Message) },
                        new KHButtonTemplate { Name = Constants.Potion, Cost = 10, Value = 1, ManipulationType = ManipulationType.Set, Description = "Give Elven Bandana", ImageUrl = "Armor/Elven_Bandana.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot1Message) },
                        new KHButtonTemplate { Name = Constants.HiPotion, Cost = 10, Value = 2, ManipulationType = ManipulationType.Set, Description = "Give Divine Bandana", ImageUrl = "Armor/Divine_Bandana.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot1Message) },
                        new KHButtonTemplate { Name = Constants.Ether, Cost = 10, Value = 3, ManipulationType = ManipulationType.Set, Description = "Give Power Band", ImageUrl = "Armor/Power_Band.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot1Message) },
                        new KHButtonTemplate { Name = Constants.Elixir, Cost = 10, Value = 4, ManipulationType = ManipulationType.Set, Description = "Give Buster Band", ImageUrl = "Armor/Buster_Band.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot1Message) },
                        new KHButtonTemplate { Name = Constants.MegaPotion, Cost = 10, Value = 5, ManipulationType = ManipulationType.Set, Description = "Give Champion Belt", ImageUrl = "Armor/Champion_Belt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot1Message) },
                        new KHButtonTemplate { Name = Constants.MegaEther, Cost = 10, Value = 6, ManipulationType = ManipulationType.Set, Description = "Give Protect Belt", ImageUrl = "Armor/Protect_Belt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot1Message) },
                        new KHButtonTemplate { Name = Constants.Megalixir, Cost = 10, Value = 7, ManipulationType = ManipulationType.Set, Description = "Give Gaia Belt", ImageUrl = "Armor/Gaia_Belt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot1Message) },
                    }
                },
                new KHButtonTemplate
                {
                    Name = "Change Item Slot 2",
                    Category = GroupType.Donald,
                    Cost = 0,
                    Description = "Update Donald's Item Slot 2",
                    ImageUrl = "Items/Megalixir.png",
                    SubMethodParams = new List<KHButtonTemplate>
                    {
                        new KHButtonTemplate { Name = Constants.None, Cost = 10, Value = 0, ManipulationType = ManipulationType.Set, Description = "Give Elven Bandana", ImageUrl = "Armor/Elven_Bandana.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot2Message) },
                        new KHButtonTemplate { Name = Constants.Potion, Cost = 10, Value = 1, ManipulationType = ManipulationType.Set, Description = "Give Elven Bandana", ImageUrl = "Armor/Elven_Bandana.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot2Message) },
                        new KHButtonTemplate { Name = Constants.HiPotion, Cost = 10, Value = 2, ManipulationType = ManipulationType.Set, Description = "Give Divine Bandana", ImageUrl = "Armor/Divine_Bandana.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot2Message) },
                        new KHButtonTemplate { Name = Constants.Ether, Cost = 10, Value = 3, ManipulationType = ManipulationType.Set, Description = "Give Power Band", ImageUrl = "Armor/Power_Band.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot2Message) },
                        new KHButtonTemplate { Name = Constants.Elixir, Cost = 10, Value = 4, ManipulationType = ManipulationType.Set, Description = "Give Buster Band", ImageUrl = "Armor/Buster_Band.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot2Message) },
                        new KHButtonTemplate { Name = Constants.MegaPotion, Cost = 10, Value = 5, ManipulationType = ManipulationType.Set, Description = "Give Champion Belt", ImageUrl = "Armor/Champion_Belt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot2Message) },
                        new KHButtonTemplate { Name = Constants.MegaEther, Cost = 10, Value = 6, ManipulationType = ManipulationType.Set, Description = "Give Protect Belt", ImageUrl = "Armor/Protect_Belt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot2Message) },
                        new KHButtonTemplate { Name = Constants.Megalixir, Cost = 10, Value = 7, ManipulationType = ManipulationType.Set, Description = "Give Gaia Belt", ImageUrl = "Armor/Gaia_Belt.png", Method = EventCallback.Factory.Create<MemoryParameters>(this, this.messageHubMessages.SendDonaldItemSlot2Message) },
                    }
                },
            };

            return items;
        }
    }
}