using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class ImportExportOptionSettings
    {
        // Key: Option Category - Key: OptionName -  Value: Setting
        public Dictionary<string, Dictionary<string, List<Setting>>> Settings { get; set; }
        // Key: Cost - Value: Cooldown
        public Dictionary<string, string> CostCooldowns { get; set; }
    }

    [System.Serializable]
    public class Setting
    {
        public string OptionName { get; set; }
        public bool IsActive { get; set; }
        public int Cost { get; set; }
    }
}