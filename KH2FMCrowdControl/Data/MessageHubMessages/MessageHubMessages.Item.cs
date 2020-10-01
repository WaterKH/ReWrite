using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class MessageHubMessages
    {

        #region Items

        #region Base Items

        public async void SendPotionMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Potion", Address = 0x2032F0B0, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendHiPotionMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Hi-Potion", Address = 0x2032F0B1, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendEtherMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Ether", Address = 0x2032F0B2, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendElixirMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Elixir", Address = 0x2032F0B3, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMegaPotionMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Mega-Potion", Address = 0x2032F0B4, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMegaEtherMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Mega-Ether", Address = 0x2032F0B6, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMegaElixirMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Mega-Elixir", Address = 0x2032F111, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendTentMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Tent", Address = 0x2032F194, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDriveRecoveryMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Drive Recovery", Address = 0x2032F195, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendHighDriveRecoveryMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "High Drive Recovery", Address = 0x2032F196, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendPowerBoostMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Power Boost", Address = 0x2032F196, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMagicBoostMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Magic Boost", Address = 0x2032F197, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDefenseBoostMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Defense Boost", Address = 0x2032F198, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendAPBoostMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "AP Boost", Address = 0x2032F199, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Base Items

        #region Weapons

        #region Sora

        public async void SendKingdomKeyMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Kingdom Key", Address = 0x2032F0D1, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendOathkeeperMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Oathkeeper", Address = 0x2032F0D2, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendOblivionMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Oblivion", Address = 0x2032F0D3, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDetectionSaberMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Detection Saber", Address = 0x2032F0D4, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFrontierOfUltimaMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Frontier of Ultima", Address = 0x2032F0D5, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendStarSeekerMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "StarSeeker", Address = 0x2032F1AB, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendHiddenDragonMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Hidden Dragon", Address = 0x2032F1AC, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendHerosCrestMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Hero's Crest", Address = 0x2032F1AF, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMonochromeMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Monochrome", Address = 0x2032F1B0, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFollowTheWindMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Follow the Wind", Address = 0x2032F1B1, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendCircleOfLifeMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Circle of Life", Address = 0x2032F1B2, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendPhotonDebuggerMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Photon Debugger", Address = 0x2032F1B3, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGullWingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Gull Wing", Address = 0x2032F1B4, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendRumblingRoseMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Rumbling Rose", Address = 0x2032F1B5, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGuardianSoulMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Guardian Soul", Address = 0x2032F1B6, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendWishingLampMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Wishing Lamp", Address = 0x2032F1B7, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDecisivePumpkinMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Decisive Pumpkin", Address = 0x2032F1B8, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSleepingLionMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sleeping Lion", Address = 0x2032F1B9, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSweetMemoriesMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sweet Memories", Address = 0x2032F1BA, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMysteriousAbyssMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Mysterious Abyss", Address = 0x2032F1BB, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendBondOfFlameMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Bond of Flame", Address = 0x2032F1BC, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFatalCrestMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Fatal Crest", Address = 0x2032F1BD, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFenrirMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Fenrir", Address = 0x2032F1BE, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendUltimaWeaponMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Ultima Weapon", Address = 0x2032F1BF, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendTwoBecomeOneMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Two Become One", Address = 0x2032F1C8, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendWinnersProofMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Winner's Proof", Address = 0x2032F1C9, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Sora

        #region Donald

        public async void SendMagesStaffMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Mage's Staff", Address = 0x2032F0F3, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendHammerStaffMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Hammer Staff", Address = 0x2032F11F, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendVictoryBellMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Victory Bell", Address = 0x2032F120, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMeteorStaffMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Meteor Staff", Address = 0x2032F121, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendCometStaffMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Comet Staff", Address = 0x2032F122, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendLordsBroomMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Lord's Broom", Address = 0x2032F123, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendWisdomWandMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Wisdom Wand", Address = 0x2032F124, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendRisingDragonMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Rising Dragon", Address = 0x2032F125, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendNobodyLanceMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Nobody Lance", Address = 0x2032F126, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendShamansRelicMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Shaman's Relic", Address = 0x2032F127, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendShamansRelicPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Shaman's Relic+", Address = 0x2032F1E6, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendStaffOfDetectionMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Staff of Detection", Address = 0x2032F12A, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSaveTheQueenMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Save the Queen", Address = 0x2032F12D, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSaveTheQueenPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Save the Queen+", Address = 0x2032F1C2, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendCenturionMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Centurion", Address = 0x2032F1CA, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendCenturionPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Centurion+", Address = 0x2032F1CB, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendPlainMushroomMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Plain Mushroom", Address = 0x2032F1CC, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendPlainMushroomPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Plain Mushroom+", Address = 0x2032F1CD, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendPreciousMushroomMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Precious Mushroom", Address = 0x2032F1CE, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendPreciousMushroomPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Precious Mushroom+", Address = 0x2032F1CF, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendPremiumMushroomMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Premium Mushroom", Address = 0x2032F1D0, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Donald

        #region Goofy

        public async void SendKnightsShieldMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Knight's Shield", Address = 0x2032F0D9, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDetectionShieldMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Detection Shield", Address = 0x2032F0DA, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendAdamantShieldMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Adamant Shield", Address = 0x2032F116, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendChainGearMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Chain Gear", Address = 0x2032F117, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendOgreShieldMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Ogre Shield", Address = 0x2032F118, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFallingStarMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Falling Star", Address = 0x2032F119, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDreamcloudMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Dreamcloud", Address = 0x2032F11A, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendKnightDefenderMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Knight Defender", Address = 0x2032F11B, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGenjiShieldMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Genji Shield", Address = 0x2032F11C, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendAkashicRecordMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Akashic Record", Address = 0x2032F11D, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendAkashicRecordPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Akashic Record+", Address = 0x2032F1E7, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendNobodyGuardMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Nobody Guard", Address = 0x2032F11E, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSaveTheKingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Save the King", Address = 0x2032F1AE, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSaveTheKingPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Save the King+", Address = 0x2032F1C3, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFrozenPrideMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Frozen Pride", Address = 0x2032F1D1, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFrozenPridePlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Centurion+", Address = 0x2032F1D2, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendJoyousMushroomMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Joyous Mushroom", Address = 0x2032F1D3, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendJoyousMushroomPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Joyous Mushroom+", Address = 0x2032F1D4, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMajesticMushroomMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Majestic Mushroom", Address = 0x2032F1D5, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMajesticMushroomPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Majestic Mushroom+", Address = 0x2032F1D6, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendUltimateMushroomMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Ultimate Mushroom", Address = 0x2032F1D7, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Goofy

        #endregion Weapons

        #region Armor

        public async void SendElvenBandannaMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Elven Bandanna", Address = 0x2032F0EC, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDivineBandannaMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Divine Bandanna", Address = 0x2032F0ED, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendPowerBandMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Power Band", Address = 0x2032F0EE, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendBusterBandMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Buster Band", Address = 0x2032F0F6, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendProtectBeltMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Protect Belt", Address = 0x2032F0F7, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGaiaBeltMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Gaia Belt", Address = 0x2032F0FA, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendCosmicBeltMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Cosmic Belt", Address = 0x2032F101, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendShockCharmMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Shock Charm", Address = 0x2032F102, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendShockCharmPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Shock Charm+", Address = 0x2032F103, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGrandRibbonMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Grand Ribbon", Address = 0x2032F104, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFireBangleMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Fire Bangle", Address = 0x2032F107, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFiraBangleMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Fira Bangle", Address = 0x2032F108, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFiragaBangleMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Firaga Bangle", Address = 0x2032F109, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFiragunBangleMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Firagun Bangle", Address = 0x2032F10A, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendBlizzardArmletMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Blizzard Armlet", Address = 0x2032F10C, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendBlizzaraArmletMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Blizzara Armlet", Address = 0x203210D, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendBlizzagaArmletMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Blizzaga Armlet", Address = 0x2032F10E, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendBlizzagunArmletMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Blizzagun Armlet", Address = 0x2032F10F, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendThunderTrinketMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Thunder Trinket", Address = 0x2032F112, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendThundaraTrinketMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Thundara Trinket", Address = 0x2032F113, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendThundagaTrinketMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Thundaga Trinket", Address = 0x2032F114, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendThundagunTrinketMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Thundagun Trinket", Address = 0x2032F115, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendShadowAnkletMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Shadow Anklet", Address = 0x2032F129, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDarkAnkletMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Dark Anklet", Address = 0x2032F12B, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMidnightAnkletMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Midnight Anklet", Address = 0x2032F12C, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendChaosAnkletMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Chaos Anklet", Address = 0x2032F12D, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendAbasChainMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Abas Chain", Address = 0x2032F12F, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendAegisChainMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Aegis Chain", Address = 0x2032F130, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendCosmicChainMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Cosmic Chain", Address = 0x2032F136, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendAcrisiusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Acrisius", Address = 0x2032F131, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendAcrisiusPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Acrisius+", Address = 0x2032F135, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendRibbonMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Ribbon", Address = 0x2032F132, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendChampionBeltMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Champion Belt", Address = 0x2032F133, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }
        public async void SendPetiteRibbonMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Petited Ribbon", Address = 0x2032F134, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Armor

        #region Accessories

        public async void SendAbilityRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Ability Ring", Address = 0x2032F0B7, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendEngineersRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Engineer's Ring", Address = 0x2032F0B8, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendTechniciansRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Technician's Ring", Address = 0x2032F0B9, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendExpertsRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Expert's Ring", Address = 0x2032F0BA, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSardonyxRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Sardonyx Ring", Address = 0x2032F0BB, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendTourmalineRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Tourmaline Ring", Address = 0x2032F0BC, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendAquamarineRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Aquamarine Ring", Address = 0x2032F0BD, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGarnetRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Garnet Ring", Address = 0x2032F0BE, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDiamondRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Diamond Ring", Address = 0x2032F0BF, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSilverRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Silver Ring", Address = 0x2032F0C0, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendGoldRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Gold Ring", Address = 0x2032F0C1, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendPlatinumRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Platinum Ring", Address = 0x2032F0C2, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMythrilRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Mythril Ring", Address = 0x2032F0C3, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendOrichalcumRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Orichalcum Ring", Address = 0x2032F0CA, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMastersRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Master's Ring", Address = 0x2032F0CB, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMoonAmuletMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Moon Amulet", Address = 0x2032F0CC, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendStarCharmMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Star Charm", Address = 0x2032F0CE, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSkillRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Skill Ring", Address = 0x2032F0CF, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSkillfulRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Skillful Ring", Address = 0x2032F0D0, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSoldierEarringMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Soldier Earring", Address = 0x2032F0D6, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFencerEarringMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Fencer Earring", Address = 0x2032F0D7, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMageEarringMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Mage Earring", Address = 0x2032F0D8, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendSlayerEarringMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Slayer Earring", Address = 0x2032F0DC, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendCosmicRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Cosmic Ring", Address = 0x2032F0DD, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendMedalMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Medal", Address = 0x2032F0E0, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendCosmicArtsMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Cosmic Arts", Address = 0x2032F0E1, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendShadowArchiveMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Shadow Archive", Address = 0x2032F0E2, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendShadowArchivePlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Shadow Archive+", Address = 0x2032F0E7, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendLuckyRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Lucky Ring", Address = 0x2032F0E8, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFullBloomMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Full Bloom", Address = 0x2032F0E9, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendFullBloomPlusMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Full Bloom+", Address = 0x2032F0EB, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendDrawRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Draw Ring", Address = 0x2032F0EA, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        public async void SendExecutivesRingMessage(MemoryParameters memoryParams)
        {
            var memoryObject = new MemoryObject { Name = "Executive's Ring", Address = 0x2032F1E5, Type = DataType.Byte, ManipulationType = memoryParams.ManipulationType };
            memoryObject.Value = memoryParams.Value.ToString();

            await this.SendUpdateMemoryMessage(memoryParams.HostName, memoryObject);
        }

        #endregion Accessories

        #endregion Items
    }
}