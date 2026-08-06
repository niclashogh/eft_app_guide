using eft_app_guide.Packs;

namespace eft_app_guide.Packages.Display
{
    public record DisplayPack : BasePack
    {
        public int MapId { get; set; }

        public string MapIcon { get; set; }

        public List<DisplayElementDefault> DisplayElementDefaults { get; set; } = [];
        public List<DisplayElement> DisplayElements { get; set; } = [];
    }
}
