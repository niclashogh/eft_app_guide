namespace eft_app_guide.Models
{
    public readonly record struct DimensionRecord<T>(T Width, T Height);
    public readonly record struct PositionRecord<THorizontal, TVertical>(THorizontal HorizontalPlacement, TVertical VerticalPlacement);

    public readonly record struct ViewRecord<TComponent>(TComponent Component, string Title);
}
