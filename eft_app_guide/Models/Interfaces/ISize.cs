namespace eft_app_guide.Models.Interfaces
{
    public interface ISize
    {
        double? Width { get; set; }
        double? Height { get; set; }

        bool HasSize();
    }
}
