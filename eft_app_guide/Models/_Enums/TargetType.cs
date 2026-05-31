namespace eft_app_guide.Models._Enums
{
    public enum TargetType // TODO
    {
        // InteractionTargetTypes
        Container, Extraction, Location, MarketPlace, Raid, Btr, Trader,

        // ProgressionTargetType
        Chapter, ChapterTask, CharacterLevel, Quest, Skill, SkillGroup, SkillEffect, TraderLevel, Workstation,

        // StackTargetType
        Ammunition, Currency, Item,

        // Exclusive
        StackQuantity, TargetDescription
    }
}
