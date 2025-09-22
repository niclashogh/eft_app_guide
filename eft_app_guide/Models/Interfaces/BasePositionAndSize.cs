namespace eft_app_guide.Models.Interfaces
{
    public class BasePositionAndSize : IPositionAndSize
    {
        public double? X { get; set; }
        public double? Y { get; set; }

        public double? Width { get; set; }
        public double? Height { get; set; }

        public bool HasPosition() => X.HasValue && Y.HasValue;
        public bool HasSize() => Width.HasValue && Height.HasValue;
    }
}
