namespace eft_app_guide.Models.Interfaces
{
    public class BasePosition : IPosition
    {
        public double? X { get; set; }
        public double? Y { get; set; }

        public bool HasPosition() => X.HasValue && Y.HasValue;
    }
}
