namespace eft_app_guide.DataTransferObjects.Records;

public readonly record struct PositionRecord<THorizontal, TVertical>(THorizontal HorizontalPlacement, TVertical VerticalPlacement);