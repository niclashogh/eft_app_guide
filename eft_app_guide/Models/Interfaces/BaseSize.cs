namespace eft_app_guide.Models.Interfaces
{
    public class BaseSize : ISize
    {
        public double? Width { get; set; }
        public double? Height { get; set; }

        public bool HasSize() => Width.HasValue && Height.HasValue;
    }
}
