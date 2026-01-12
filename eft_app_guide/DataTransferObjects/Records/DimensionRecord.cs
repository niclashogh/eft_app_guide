namespace eft_app_guide.DataTransferObjects.Records;

public readonly record struct DimensionRecord<T>(T Width, T Height);
