namespace eft_app_guide.Models.Interfaces
{
    public interface IPosition
    {
        double? X { get; set; }
        double? Y { get; set; }

        bool HasPosition();
    }
}
