using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeGoofyArmorOptions()
        {
            var armor = new List<ButtonTemplate>
            {
                new ButtonTemplate { Name = Constants.None, Cost = Constants.Cost750, Value = 0, ManipulationType = ManipulationType.Set, Description = "Give Elven Bandana", ImageUrl = "Armor/Elven_Bandana.png" },
                new ButtonTemplate { Name = Constants.ElvenBandana, Cost = Constants.Cost100, Value = 67, ManipulationType = ManipulationType.Set, Description = "Give Elven Bandana", ImageUrl = "Armor/Elven_Bandana.png" },
                new ButtonTemplate { Name = Constants.DivineBandana, Cost = Constants.Cost200, Value = 68, ManipulationType = ManipulationType.Set, Description = "Give Divine Bandana", ImageUrl = "Armor/Divine_Bandana.png" },
                new ButtonTemplate { Name = Constants.PowerBand, Cost = Constants.Cost200, Value = 69, ManipulationType = ManipulationType.Set, Description = "Give Power Band", ImageUrl = "Armor/Power_Band.png" },
                new ButtonTemplate { Name = Constants.BusterBand, Cost = Constants.Cost300, Value = 70, ManipulationType = ManipulationType.Set, Description = "Give Buster Band", ImageUrl = "Armor/Buster_Band.png" },
                new ButtonTemplate { Name = Constants.ChampionBelt, Cost = Constants.Cost500, Value = 305, ManipulationType = ManipulationType.Set, Description = "Give Champion Belt", ImageUrl = "Armor/Champion_Belt.png" },
                new ButtonTemplate { Name = Constants.ProtectBelt, Cost = Constants.Cost300, Value = 78, ManipulationType = ManipulationType.Set, Description = "Give Protect Belt", ImageUrl = "Armor/Protect_Belt.png" },
                new ButtonTemplate { Name = Constants.GaiaBelt, Cost = Constants.Cost400, Value = 79, ManipulationType = ManipulationType.Set, Description = "Give Gaia Belt", ImageUrl = "Armor/Gaia_Belt.png" },
                new ButtonTemplate { Name = Constants.CosmicBelt, Cost = Constants.Cost500, Value = 111, ManipulationType = ManipulationType.Set, Description = "Give Cosmic Belt", ImageUrl = "Armor/Cosmic_Belt.png" },
                new ButtonTemplate { Name = Constants.FireBangle, Cost = Constants.Cost200, Value = 173, ManipulationType = ManipulationType.Set, Description = "Give Fire Bangle", ImageUrl = "Armor/Fire_Bangle.png" },
                new ButtonTemplate { Name = Constants.FiraBangle, Cost = Constants.Cost300, Value = 174, ManipulationType = ManipulationType.Set, Description = "Give Fira Bangle", ImageUrl = "Armor/Fira_Bangle.png" },
                new ButtonTemplate { Name = Constants.FiragaBangle, Cost = Constants.Cost400, Value = 197, ManipulationType = ManipulationType.Set, Description = "Give Firaga Bangle", ImageUrl = "Armor/Firaga_Bangle.png" },
                new ButtonTemplate { Name = Constants.FiragunBangle, Cost = Constants.Cost500, Value = 284, ManipulationType = ManipulationType.Set, Description = "Give Firagun Bangle", ImageUrl = "Armor/Firagun_Bangle.png" },
                new ButtonTemplate { Name = Constants.BlizzardArmlet, Cost = Constants.Cost200, Value = 286, ManipulationType = ManipulationType.Set, Description = "Give Blizzard Armlet", ImageUrl = "Armor/Blizzard_Armlet.png" },
                new ButtonTemplate { Name = Constants.BlizzaraArmlet, Cost = Constants.Cost300, Value = 287, ManipulationType = ManipulationType.Set, Description = "Give Blizzara Armlet", ImageUrl = "Armor/Blizzara_Armlet.png" },
                new ButtonTemplate { Name = Constants.BlizzagaArmlet, Cost = Constants.Cost400, Value = 288, ManipulationType = ManipulationType.Set, Description = "Give Blizzaga Armlet", ImageUrl = "Armor/Blizzaga_Armlet.png" },
                new ButtonTemplate { Name = Constants.BlizzagunArmlet, Cost = Constants.Cost500, Value = 289, ManipulationType = ManipulationType.Set, Description = "Give Blizzagun Armlet", ImageUrl = "Armor/Blizzagun_Armlet.png" },
                new ButtonTemplate { Name = Constants.ThunderTrinket, Cost = Constants.Cost200, Value = 291, ManipulationType = ManipulationType.Set, Description = "Give Thunder Trinket", ImageUrl = "Armor/Thunder_Trinket.png" },
                new ButtonTemplate { Name = Constants.ThundaraTrinket, Cost = Constants.Cost300, Value = 292, ManipulationType = ManipulationType.Set, Description = "Give Thundara Trinket", ImageUrl = "Armor/Thundara_Trinket.png" },
                new ButtonTemplate { Name = Constants.ThundagaTrinket, Cost = Constants.Cost400, Value = 293, ManipulationType = ManipulationType.Set, Description = "Give Thundaga Trinket", ImageUrl = "Armor/Thundaga_Trinket.png" },
                new ButtonTemplate { Name = Constants.ThundagunTrinket, Cost = Constants.Cost500, Value = 294, ManipulationType = ManipulationType.Set, Description = "Give Thundagun Trinket", ImageUrl = "Armor/Thundagun_Trinket.png" },
                new ButtonTemplate { Name = Constants.ShadowAnklet, Cost = Constants.Cost200, Value = 296, ManipulationType = ManipulationType.Set, Description = "Give Shadow Anklet", ImageUrl = "Armor/Shadow_Anklet.png" },
                new ButtonTemplate { Name = Constants.DarkAnklet, Cost = Constants.Cost300, Value = 297, ManipulationType = ManipulationType.Set, Description = "Give Dark Anklet", ImageUrl = "Armor/Dark_Anklet.png" },
                new ButtonTemplate { Name = Constants.MidnightAnklet, Cost = Constants.Cost400, Value = 298, ManipulationType = ManipulationType.Set, Description = "Give Midnight Anklet", ImageUrl = "Armor/Midnight_Anklet.png" },
                new ButtonTemplate { Name = Constants.ChaosAnklet, Cost = Constants.Cost500, Value = 299, ManipulationType = ManipulationType.Set, Description = "Give Chaos Anklet", ImageUrl = "Armor/Chaos_Anklet.png" },
                new ButtonTemplate { Name = Constants.AbasChain, Cost = Constants.Cost200, Value = 301, ManipulationType = ManipulationType.Set, Description = "Give Abas Chain", ImageUrl = "Armor/Abas_Chain.png" },
                new ButtonTemplate { Name = Constants.AegisChain, Cost = Constants.Cost300, Value = 302, ManipulationType = ManipulationType.Set, Description = "Give Aegis Chain", ImageUrl = "Armor/Aegis_Chain.png" },
                new ButtonTemplate { Name = Constants.Acrisius, Cost = Constants.Cost400, Value = 303, ManipulationType = ManipulationType.Set, Description = "Give Acrisius", ImageUrl = "Armor/Acrisius.png" },
                new ButtonTemplate { Name = Constants.AcrisiusPlus, Cost = Constants.Cost500, Value = 307, ManipulationType = ManipulationType.Set, Description = "Give Acrisius+", ImageUrl = "Armor/AcrisiusPlus.png" },
                new ButtonTemplate { Name = Constants.CosmicChain, Cost = Constants.Cost750, Value = 308, ManipulationType = ManipulationType.Set, Description = "Give Cosmic Chain", ImageUrl = "Armor/Cosmic_Chain.png" },
                new ButtonTemplate { Name = Constants.ShockCharm, Cost = Constants.Cost400, Value = 132, ManipulationType = ManipulationType.Set, Description = "Give Shock Charm", ImageUrl = "Armor/Shock_Charm.png" },
                new ButtonTemplate { Name = Constants.ShockCharmPlus, Cost = Constants.Cost500, Value = 133, ManipulationType = ManipulationType.Set, Description = "Give Shock Charm+", ImageUrl = "Armor/Shock_CharmPlus.png" },
                new ButtonTemplate { Name = Constants.PetiteRibbon, Cost = Constants.Cost500, Value = 306, ManipulationType = ManipulationType.Set, Description = "Give Petite Ribbon", ImageUrl = "Armor/Petite_Ribbon.png" },
                new ButtonTemplate { Name = Constants.Ribbon, Cost = Constants.Cost750, Value = 304, ManipulationType = ManipulationType.Set, Description = "Give Ribbon", ImageUrl = "Armor/Ribbon.png" },
                new ButtonTemplate { Name = Constants.GrandRibbon, Cost = Constants.Cost1000, Value = 157, ManipulationType = ManipulationType.Set, Description = "Give Grand Ribbon", ImageUrl = "Armor/Grand_Ribbon.png" },
            };

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Change Armor Slots",
                    Category = GroupType.Goofy,
                    SubCategory = SubGroupType.Armor,
                    Cost = 0,
                    Description = "Update Goofy's Armor Slots",
                    ImageUrl = "Armor/Abas_Chain.png",
                    SubMethodParams = new List<ButtonTemplate>
                        {
                            new ButtonTemplate { Name = "No Slots", Cost = Constants.Cost1000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Armor Slots to 0", ImageUrl = "Armor/Abas_Chain.png", MethodName = "SendGoofyArmorSlotsMessage" },
                            new ButtonTemplate { Name = "1 Slot", Cost = Constants.Cost250, Value = 1, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Armor Slots to 1", ImageUrl = "Armor/Abas_Chain.png", MethodName = "SendGoofyArmorSlotsMessage" },
                            new ButtonTemplate { Name = "2 Slot", Cost = Constants.Cost200, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Armor Slots to 2", ImageUrl = "Armor/Abas_Chain.png", MethodName = "SendGoofyArmorSlotsMessage" },
                            new ButtonTemplate { Name = "3 Slot", Cost = Constants.Cost300, Value = 2, ManipulationType = ManipulationType.Set, Description = "Set Goofy's Armor Slots to 3", ImageUrl = "Armor/Abas_Chain.png", MethodName = "SendGoofyArmorSlotsMessage" },
                        }
                },
                new ButtonTemplate
                {
                    Name = "Change Armor Slot 1",
                    Category = GroupType.Goofy,
                    SubCategory = SubGroupType.Armor,
                    Cost = 0,
                    Description = "Update Goofy's Armor Slots",
                    ImageUrl = "Armor/Abas_Chain.png",
                    SubMethodParams = armor.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Armor Slot 2",
                    Category = GroupType.Goofy,
                    SubCategory = SubGroupType.Armor,
                    Cost = 0,
                    Description = "Update Goofy's Armor Slot 2",
                    ImageUrl = "Armor/Abas_Chain.png",
                    SubMethodParams = armor.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Armor Slot 3",
                    Category = GroupType.Goofy,
                    SubCategory = SubGroupType.Armor,
                    Cost = 0,
                    Description = "Update Goofy's Armor Slot 3",
                    ImageUrl = "Armor/Abas_Chain.png",
                    SubMethodParams = armor.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Change Armor Slot 1")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyArmorSlot1Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Armor Slot 2")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyArmorSlot2Message");
            options.FirstOrDefault(x => x.Name.Equals("Change Armor Slot 3")).SubMethodParams.ForEach(x => x.MethodName = "SendGoofyArmorSlot3Message");

            return options;
        }
    }
}