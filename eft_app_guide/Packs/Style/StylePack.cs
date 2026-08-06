using eft_app_guide.Packages.Display;

namespace eft_app_guide.Packages.Style
{
    public class StylePack // TODO - Add SkillIcon
    {
        public int Version { get; set; }
        public DateTime Updated { get; set; }

        public List<AssetCredit> AssetCredits { get; set; } = [];

        public List<CharacterLevelBadge> CharacterLevelBadge { get; set; } = [];
        public List<PatronIcon> PatronIcons { get; set; } = [];
    }
}
