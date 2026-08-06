using eft_app_guide.Packs;

namespace eft_app_guide.Packages.Style
{
    public record StylePack : BasePack // TODO - Add SkillIcon(s)
    {
        public List<CharacterLevelBadge> CharacterLevelBadge { get; set; } = [];
        public List<PatronIcon> PatronIcons { get; set; } = [];
    }
}
