namespace DnD_Character_Sheet.Models._4e
{
    public class Character4E
    {
        public string? PlayerName { get; set; }
        public string? CharacterName { get; set; }
        public int? Level { get; set; }
        public string? Class { get; set; }
        public string? ParagonPath { get; set; }
        public string? EpicDestiny { get; set; }
        public int? TotalXP { get; set; }
        public string? Race { get; set; }
        public string? Size { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? Alignment { get; set; }
        public string? Deity { get; set; }
        public string? Affiliation { get; set; }
        public int? MiscInitiativeModifier { get; set; }
        public int? Strength { get; set; }
        public int? Constitution { get; set; }
        public int? Dexterity { get; set; }
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Charisma { get; set; }
        public int? MaxHitPoints { get; set; }
        public int? CurrentHitPoints { get; set; }
        public int? SurgesPerDay { get; set; }
        public int? TempHitPoints { get; set; }
        public bool? SecondWindUsed { get; set; }
        public int? DeathSavingThrowFailures { get; set; }
        public string? SavingThrowModifiers { get; set; }
        public string? Resistances { get; set; }
        public string? Vulnerabilities { get; set; }
        public string? Immunities { get; set; }
        public string? CurrentConditionsAndEffects { get; set; }
        public List<Skills4E>? TrainedSkills { get; set; }
        public int? ArmorPenalty { get; set; }
        public Dictionary<Skills4E, int>? MiscSkillModifiers { get; set; }
        public Defense? Armor { get; set; }
        public Defense? Fortitude { get; set; }
        public Defense? Reflex { get; set; }
        public Defense? Will { get; set; }
        public int? ActionPoints { get; set; }
        public List<string>? RaceFeatures { get; set; }
        public List<string>? OtherFeatures { get; set; }
        public List<string>? Languages { get; set; }
        public Speed? Speed { get; set; }

    }
}
