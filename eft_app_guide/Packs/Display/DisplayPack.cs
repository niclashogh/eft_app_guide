namespace eft_app_guide.Packages.Display
{
    public class DisplayPack
    {
        public int MapId { get; set; }

        public string MapIcon { get; set; }

        public int Version { get; set; }
        public DateTime Updated {  get; set; }

        public List<AssetCredit> AssetCredits { get; set; } = [];

        public List<DisplayTypeDefault> DisplayTypeDefaults { get; set; } = [];
        public List<DisplayItem> DisplayItems { get; set; } = [];
    }
}
