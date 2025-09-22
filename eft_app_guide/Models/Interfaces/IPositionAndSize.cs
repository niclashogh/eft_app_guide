namespace eft_app_guide.Models.Interfaces
{
    public interface IPositionAndSize
    {
        double? X { get; set; }
        double? Y { get; set; }

        double? Width { get; set; }
        double? Height { get; set; }

        bool HasPosition();
        bool HasSize();
    }
}
