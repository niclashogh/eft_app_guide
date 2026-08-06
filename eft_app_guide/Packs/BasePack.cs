namespace eft_app_guide.Packs
{
    public abstract record BasePack
    {
        public int Version { get; set; }
        public DateTime Updated { get; set; }

        public List<PackCredit> Credits { get; set; } = [];
    }
}
