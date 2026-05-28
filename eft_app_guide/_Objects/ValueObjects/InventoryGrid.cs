namespace eft_app_guide._Objects.ValueObjects
{
    public readonly struct InventoryGrid
    {
        public int Width { get; }
        public int Height { get; }

        public InventoryGrid(int width, int height)
        {
            if (width == 0 || height == 0) throw new ArgumentOutOfRangeException("Grid size must be at least 1x1.");

            Width = width;
            Height = height;
        }

        public override string ToString() => $"{Width}x{Height}";
    }
}
