namespace eft_app_guide.Models._Internal.Records;

public readonly record struct PositionRecord<THorizontal, TVertical>(THorizontal HorizontalPlacement, TVertical VerticalPlacement);