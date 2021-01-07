using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeSoraWeaponsOptions()
        {
            var keyblades = new List<ButtonTemplate>
            {
                //new ButtonTemplate { Name = Constants.None, Cost = Constants.Cost5000, Value = 0, ManipulationType = ManipulationType.Set, Description = "Equip Kingdom Key to Sora's Weapon Slot", ImageUrl = "Keyblades/Kingdom_Key.png" },
                new ButtonTemplate { Name = Constants.KingdomKey, Cost = Constants.Cost400, Value = 41, ManipulationType = ManipulationType.Set, Description = "Equip Kingdom Key to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Kingdom_Key.png" },
                new ButtonTemplate { Name = Constants.Oathkeeper, Cost = Constants.Cost500, Value = 42, ManipulationType = ManipulationType.Set, Description = "Equip Oathekeeper to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Oathkeeper.png" },
                new ButtonTemplate { Name = Constants.Oblivion, Cost = Constants.Cost500, Value = 43, ManipulationType = ManipulationType.Set, Description = "Equip Oblivion to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Oblivion.png" },
                new ButtonTemplate { Name = Constants.StarSeeker, Cost = Constants.Cost300, Value = 480, ManipulationType = ManipulationType.Set, Description = "Equip Star Seeker to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Star_Seeker.png" },
                new ButtonTemplate { Name = Constants.HiddenDragon, Cost = Constants.Cost300, Value = 481, ManipulationType = ManipulationType.Set, Description = "Equip Hidden Dragon to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Hidden_Dragon.png" },
                new ButtonTemplate { Name = Constants.HerosCrest, Cost = Constants.Cost300, Value = 484, ManipulationType = ManipulationType.Set, Description = "Equip Hero's Crest to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Heros_Crest.png" },
                new ButtonTemplate { Name = Constants.Monochrome, Cost = Constants.Cost400, Value = 485, ManipulationType = ManipulationType.Set, Description = "Equip Monochrome to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Monochrome.png" },
                new ButtonTemplate { Name = Constants.FollowTheWind, Cost = Constants.Cost300, Value = 486, ManipulationType = ManipulationType.Set, Description = "Equip Follow the Wind to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Follow_the_Wind.png" },
                new ButtonTemplate { Name = Constants.CircleOfLife, Cost = Constants.Cost400, Value = 487, ManipulationType = ManipulationType.Set, Description = "Equip Circle of Life to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Circle_of_Life.png" },
                new ButtonTemplate { Name = Constants.PhotonDebugger, Cost = Constants.Cost400, Value = 488, ManipulationType = ManipulationType.Set, Description = "Equip Photon Debugger to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Photon_Debugger.png" },
                new ButtonTemplate { Name = Constants.GullWing, Cost = Constants.Cost500, Value = 489, ManipulationType = ManipulationType.Set, Description = "Equip Gull Wing to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Gull_Wing.png" },
                new ButtonTemplate { Name = Constants.RumblingRose, Cost = Constants.Cost400, Value = 490, ManipulationType = ManipulationType.Set, Description = "Equip Rumbling Rose to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Rumbling_Rose.png" },
                new ButtonTemplate { Name = Constants.GuardianSoul, Cost = Constants.Cost300, Value = 491, ManipulationType = ManipulationType.Set, Description = "Equip Guardian Soul to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Guardian_Soul.png" },
                new ButtonTemplate { Name = Constants.WishingLamp, Cost = Constants.Cost300, Value = 492, ManipulationType = ManipulationType.Set, Description = "Equip Wishing Lamp to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Wishing_Lamp.png" },
                new ButtonTemplate { Name = Constants.DecisivePumpkin, Cost = Constants.Cost500, Value = 493, ManipulationType = ManipulationType.Set, Description = "Equip Decisive Pumpkin to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Decisive_Pumpkin.png" },
                new ButtonTemplate { Name = Constants.SleepingLion, Cost = Constants.Cost500, Value = 494, ManipulationType = ManipulationType.Set, Description = "Equip Sleeping Lion to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Sleeping_Lion.png" },
                new ButtonTemplate { Name = Constants.SweetMemories, Cost = Constants.Cost750, Value = 495, ManipulationType = ManipulationType.Set, Description = "Equip Sweet Memories to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Sweet_Memories.png" },
                new ButtonTemplate { Name = Constants.MysteriousAbyss, Cost = Constants.Cost400, Value = 496, ManipulationType = ManipulationType.Set, Description = "Equip Mysterious Abyss to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Mysterious_Abyss.png" },
                new ButtonTemplate { Name = Constants.BondOfFlame, Cost = Constants.Cost500, Value = 498, ManipulationType = ManipulationType.Set, Description = "Equip Bond of Flame to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Bond_of_Flame.png" },
                new ButtonTemplate { Name = Constants.TwoBecomeOne, Cost = Constants.Cost750, Value = 543, ManipulationType = ManipulationType.Set, Description = "Equip Two Become One to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Two_Become_One.png" },
                new ButtonTemplate { Name = Constants.FatalCrest, Cost = Constants.Cost500, Value = 497, ManipulationType = ManipulationType.Set, Description = "Equip Fatal Crest to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Fatal_Crest.png" },
                new ButtonTemplate { Name = Constants.Fenrir, Cost = Constants.Cost500, Value = 499, ManipulationType = ManipulationType.Set, Description = "Equip Fenrir to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Fenrir.png" },
                new ButtonTemplate { Name = Constants.UltimaWeapon, Cost = Constants.Cost1000, Value = 500, ManipulationType = ManipulationType.Set, Description = "Equip Ultimate Weapon to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Ultima_Weapon.png" },
                new ButtonTemplate { Name = Constants.WinnersProof, Cost = Constants.Cost1000, Value = 544, ManipulationType = ManipulationType.Set, Description = "Equip Winner's Proof to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Winners_Proof.png" },
                new ButtonTemplate { Name = Constants.DetectionSaber, Cost = Constants.Cost1000, Value = 44, ManipulationType = ManipulationType.Set, Description = "Equip Detection Saber to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Kingdom_Key_D.png" },
                new ButtonTemplate { Name = Constants.FrontierOfUltima, Cost = Constants.Cost1000, Value = 45, ManipulationType = ManipulationType.Set, Description = "Equip Frontier of Ultima to Sora's Weapon Slot", ImageUrl = "Items/Give/Keyblades/Ultima_Weapon.png" },
            };

            var options = new List<ButtonTemplate> {

                new ButtonTemplate
                {
                    Name = "Equip Keyblade",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Weapons,
                    Cost = 0,
                    Description = "Choose which Keyblade to have Sora Wield",
                    ImageUrl = "Sora/SetKeySora.png",
                    SubMethodParams = keyblades.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Equip Valor Keyblade",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Weapons,
                    Cost = 0,
                    Description = "Choose which Keyblade to have Sora Wield While in Valor Form",
                    ImageUrl = "Sora/Drive/SetKeyValor.png",
                    SubMethodParams = keyblades.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Equip Master Keyblade",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Weapons,
                    Cost = 0,
                    Description = "Choose which Keyblade to have Sora Wield While in Master Form",
                    ImageUrl = "Sora/Drive/SetKeyMaster.png",
                    SubMethodParams = keyblades.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Equip Final Keyblade",
                    Category = GroupType.Sora,
                    SubCategory = SubGroupType.Weapons,
                    Cost = 0,
                    Description = "Choose which Keyblade to have Sora Wield While in Final Form",
                    ImageUrl = "Sora/Drive/SetKeyFinal.png",
                    SubMethodParams = keyblades.CreateListFromList()
                }
            };

            options.FirstOrDefault(x => x.Name.Equals("Equip Keyblade")).SubMethodParams.ForEach(x => x.MethodName = "SendEquipKeybladeMessage");
            options.FirstOrDefault(x => x.Name.Equals("Equip Valor Keyblade")).SubMethodParams.ForEach(x => x.MethodName = "SendEquipValorKeybladeMessage");
            options.FirstOrDefault(x => x.Name.Equals("Equip Master Keyblade")).SubMethodParams.ForEach(x => x.MethodName = "SendEquipMasterKeybladeMessage");
            options.FirstOrDefault(x => x.Name.Equals("Equip Final Keyblade")).SubMethodParams.ForEach(x => x.MethodName = "SendEquipFinalKeybladeMessage");

            return options;
        }
    }
}