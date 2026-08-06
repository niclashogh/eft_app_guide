namespace eft_app_guide.Models.Enums.ReferenceTypes
{
    public enum TargetType // TODO
    {
        // InteractionTargetTypes
        Container, Extraction, Location, MarketPlace, Raid, Btr, Trader,

        // ProgressionTargetType
        Achievement, Chapter, ChapterTask, CharacterLevel, Quest, Skill, SkillGroup, SkillEffect, TraderLevel, Workstation,

        // StackTargetType
        Ammunition, Currency, Item,

        // Exclusive
        StackQuantity, TargetDescription
    }
}
