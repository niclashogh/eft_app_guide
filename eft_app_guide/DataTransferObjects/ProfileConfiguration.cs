namespace eft_app_guide.DataTransferObjects
{
    public class ProfileConfiguration // TODO - DEL
    {
        public (string Name, string Database) SelectedProfile { get; set; } = ("EFT PVP", "eft_pvp");
        public List<(string Name, string Database)> Profiles { get; set; } = new();
    }
}
