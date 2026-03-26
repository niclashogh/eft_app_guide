
namespace eft_app_guide.DataTransferObjects.ValueObjects
{
    public readonly struct InventoryGrid // TODO : Maybe del and make a parsre/validator at the Repo-layer, instead of a model-layer
    {
        public byte Width { get; }
        public byte Height { get; }

        public InventoryGrid(byte width, byte height)
        {
            if (width == 0 || height == 0) throw new ArgumentOutOfRangeException("Grid size must be at least 1x1.");

            Width = width;
            Height = height;
        }

        public override string ToString() => $"{Width}x{Height}";
    }
}
