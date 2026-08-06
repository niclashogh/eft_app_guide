namespace eft_app_guide.Models.Enums.ReferenceTypes
{
    public enum TargetType // TODO
    {
        // InteractionTargetTypes
        Container, Extraction, Location, MarketPlace, Raid, Btr, Patron,

        // ProgressionTargetType
        Achievement, Chapter, ChapterTask, CharacterLevel, Quest, Skill, SkillGroup, SkillEffect, PatronLevel, Workstation,

        // StackTargetType
        Ammunition, Currency, Item,

        // Exclusive
        StackQuantity, TargetDescription
    }
}
