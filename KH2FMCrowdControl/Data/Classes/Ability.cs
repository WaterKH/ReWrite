namespace KH2FMCrowdControl.Data
{
    public class Ability
    {
        public string Name { get; set; }
        public int ValueAddress { get; set; } // Abilities are queued up in a list... Static addresses don't make sense
        public int ToggleAddress { get; set; } // Abilities are queued up in a list... Static addresses don't make sense
        public int Value { get; set; }
        public int ToggleValue { get; set; }
        public int MaxNumber { get; set; } = 1;
    }
}