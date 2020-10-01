using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public static class Constants
    {
        public static string None = "None";

        #region Costs & Cooldowns

        public static int Cost10 = 10;
        public static int Cost25 = 25;
        public static int Cost50 = 50;
        public static int Cost75 = 75;
        public static int Cost100 = 100;
        public static int Cost150 = 150;
        public static int Cost200 = 200;
        public static int Cost250 = 250;
        public static int Cost300 = 300;
        public static int Cost350 = 350;
        public static int Cost400 = 400;
        public static int Cost450 = 450;
        public static int Cost500 = 500;
        public static int Cost550 = 550;
        public static int Cost600 = 600;
        public static int Cost650 = 650;
        public static int Cost700 = 700;
        public static int Cost750 = 750;
        public static int Cost800 = 800;
        public static int Cost850 = 850;
        public static int Cost900 = 900;
        public static int Cost950 = 950;
        public static int Cost1000 = 1000;
        public static int Cost2000 = 2000;
        public static int Cost3000 = 3000;
        public static int Cost4000 = 4000;
        public static int Cost5000 = 5000;
        public static int Cost10000 = 10000;

        // Key: Cost - Value: Cooldown value (in seconds)
        public static Dictionary<int, int> Cooldowns = new Dictionary<int, int>
        {
            { Cost10, 5 }, { Cost25, 7 }, { Cost50, 10 }, { Cost75, 12 }, { Cost100, 15 }, { Cost250, 20 }, { Cost500, 25 }, 
            { Cost750, 45 }, { Cost1000, 60 }, { Cost2000, 75 }, { Cost3000, 100 }, { Cost4000, 115 }, { Cost5000, 120 }, 
            { Cost10000, 180 }
        };

        #endregion Costs & Cooldowns 

        #region Base Items

        public static string Potion = "Potion";
        public static string HiPotion = "Hi-Potion";
        public static string Ether = "Ether";
        public static string Elixir = "Elixir";
        public static string MegaPotion = "Mega-Potion";
        public static string MegaEther = "Mega-Ether";
        public static string Megalixir = "Megalixir";
        public static string Tent = "Tent";
        public static string DriveRecovery = "Drive Recovery";
        public static string HighDriveRecovery = "High Drive Recovery";
        public static string PowerBoost = "Power Boost";
        public static string MagicBoost = "Magic Boost";
        public static string DefenseBoost = "Defense Boost";
        public static string APBoost = "AP Boost";

        #endregion Base Items

        #region Keyblades

        public static string KingdomKey = "Kingdom Key";
        public static string Oathkeeper = "Oathkeeper";
        public static string Oblivion = "Oblivion";
        public static string DetectionSaber = "Detection Saber";
        public static string StarSeeker = "Star Seeker";
        public static string HiddenDragon = "Hidden Dragon";
        public static string HerosCrest = "Hero's Crest";
        public static string Monochrome = "Monochrome";
        public static string FollowTheWind = "Follow the Wind";
        public static string CircleOfLife = "Circle of Life";
        public static string PhotonDebugger = "Photon Debugger";
        public static string GullWing = "Gull Wing";
        public static string RumblingRose = "Rumbling Rose";
        public static string GuardianSoul = "Guardian Soul";
        public static string WishingLamp = "Wishing Lamp";
        public static string DecisivePumpkin = "Decisive Pumpkin";
        public static string SleepingLion = "Sleeping Lion";
        public static string SweetMemories = "Sweet Memories";
        public static string MysteriousAbyss = "Mysterious Abyss";
        public static string BondOfFlame = "Bond of Flame";
        public static string FatalCrest = "Fatal Crest";
        public static string Fenrir = "Fenrir";
        public static string UltimaWeapon = "Ultima Weapon";
        public static string TwoBecomeOne = "Two Become One";
        public static string WinnersProof = "Winner's Proof";

        #endregion Keyblades

        #region Staffs

        public static string MagesStaff = "Mage's Staff";
        public static string HammerStaff = "Hammer Stuff";
        public static string VictoryBell = "Victory Bell";
        public static string MeteorStaff = "Meteor Staff";
        public static string CometStaff = "Comet Staff";
        public static string LordsBroom = "Lord's Broom";
        public static string WisdomWand = "Wisdom Wand";
        public static string RisingDragon = "Rising Dragon";
        public static string NobodyLance = "Nobody Lance";
        public static string ShamansRelic = "Shaman's Relic";
        public static string ShamansRelicPlus = "Shaman's Relic+";
        public static string StaffOfDetection = "Staff of Detection";
        public static string SaveTheQueen = "Save the Queen";
        public static string SaveTheQueenPlus = "Save the Queen+";
        public static string Centurion = "Centurion";
        public static string CenturionPlus = "Centurion+";
        public static string PlainMushroom = "Plain Mushroom";
        public static string PlainMushroomPlus = "Plain Mushroom+";
        public static string PreciousMushroom = "Precious Mushroom";
        public static string PreciousMushroomPlus = "Precious Mushroom+";
        public static string PremiumMushroom = "Premium Mushroom";

        #endregion Staffs

        #region Shields

        public static string KnightsShield = "Mage's Staff";
        public static string DetectionShield = "Hammer Stuff";
        public static string AdamantShield = "Victory Bell";
        public static string ChainGear = "Meteor Staff";
        public static string OgreShield = "Comet Staff";
        public static string FallingStar = "Lord's Broom";
        public static string Dreamcloud = "Wisdom Wand";
        public static string KnightDefender = "Rising Dragon";
        public static string GenjiShield = "Nobody Lance";
        public static string AkashicRecord = "Shaman's Relic";
        public static string AkashicRecordPlus = "Shaman's Relic+";
        public static string NobodyGuard = "Staff of Detection";
        public static string SaveTheKing = "Save the Queen";
        public static string SaveTheKingPlus = "Save the Queen+";
        public static string FrozenPride = "Centurion";
        public static string FrozenPridePlus = "Centurion+";
        public static string JoyousMushroom = "Plain Mushroom";
        public static string JoyousMushroomPlus = "Plain Mushroom+";
        public static string MajesticMushroom = "Precious Mushroom";
        public static string MajesticMushroomPlus = "Precious Mushroom+";
        public static string UltimateMushroom = "Premium Mushroom";

        #endregion Shields

        #region Armor

        public static string ElvenBandana = "Elven Bandana";
        public static string DivineBandana = "Divine Bandana";
        public static string PowerBand = "Power Band";
        public static string BusterBand = "Buster Band";
        public static string ProtectBelt = "Protect Belt";
        public static string GaiaBelt = "Gaia Belt";
        public static string CosmicBelt = "Cosmic Belt";
        public static string ShockCharm = "Shock Charm";
        public static string ShockCharmPlus = "Shock Charm+";
        public static string FireBangle = "Fire Bangle";
        public static string FiraBangle = "Fira Bangle";
        public static string FiragaBangle = "Firaga Bangle";
        public static string FiragunBangle = "Firagun Bangle";
        public static string BlizzardArmlet = "Blizzard Armlet";
        public static string BlizzaraArmlet = "Blizzara Armlet";
        public static string BlizzagaArmlet = "Blizzaga Armlet";
        public static string BlizzagunArmlet = "Blizzagun Armlet";
        public static string ThunderTrinket = "Thunder Trinket";
        public static string ThundaraTrinket = "Thundara Trinket";
        public static string ThundagaTrinket = "Thundaga Trinket";
        public static string ThundagunTrinket = "Thundagun Trinket";
        public static string ShadowAnklet = "Shadow Anklet";
        public static string DarkAnklet = "Dark Anklet";
        public static string MidnightAnklet = "Midnight Anklet";
        public static string ChaosAnklet = "Chaos Anklet";
        public static string AbasChain = "Abas Chain";
        public static string AegisChain = "Aegis Chain";
        public static string Acrisius = "Acrisius";
        public static string AcrisiusPlus = "Acrisius+";
        public static string PetiteRibbon = "Petite Ribbon";
        public static string Ribbon = "Ribbon";
        public static string GrandRibbon = "Grand Ribbon"; 
        public static string ChampionBelt = "Champion Belt";
        public static string CosmicChain = "Cosmic Chain";

        #endregion Armor

        #region Accessories

        public static string AbilityRing = "Ability Ring";
        public static string EngineersRing = "Engineer's Ring";
        public static string TechniciansRing = "Technician's Ring";
        public static string ExpertsRing = "Expert's Ring";
        public static string SardonyxRing = "Sardonyx Ring";
        public static string TourmalineRing = "Tourmaline Ring";
        public static string AquamarineRing = "Aquamarine Ring";
        public static string GarnetRing = "Garnet Ring";
        public static string DiamondRing = "Diamond Ring";
        public static string SilverRing = "Silver Ring";
        public static string GoldRing = "Gold Ring";
        public static string PlatinumRing = "Platinum Ring";
        public static string MythrilRing = "Mythril Ring";
        public static string OrichalcumRing = "Orichalcum Ring";
        public static string MastersRing = "Master's Ring";
        public static string MoonAmulet = "Moon Amulet";
        public static string StarCharm = "Star Charm";
        public static string SkillRing = "Skill Ring";
        public static string SkillfulRing = "Skillful Ring";
        public static string SoldierEarring = "Soldier Earring";
        public static string FencerEarring = "Fencer Earring";
        public static string MageEarring = "Mage Earring";
        public static string SlayerEarring = "Slayer Earring";
        public static string CosmicRing = "Cosmic Ring";
        public static string Medal = "Medal";
        public static string CosmicArts = "Cosmic Arts";
        public static string ShadowArchive = "Shadow Archive";
        public static string ShadowArchivePlus = "Shadow Archive+";
        public static string LuckyRing = "Lucky Ring";
        public static string DrawRing = "Draw Ring";
        public static string FullBloom = "Full Bloom";
        public static string FullBloomPlus = "Full Bloom+";
        public static string ExecutivesRing = "Executive's Ring";

        #endregion Accessories

        public static string Give(string value)
        {
            return $"Give {value}";
        }

        public static string Take(string value)
        {
            return $"Take {value}";
        }
    }
}