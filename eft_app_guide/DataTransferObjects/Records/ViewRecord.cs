namespace eft_app_guide.DataTransferObjects.Records;

public readonly record struct ViewRecord<TComponent>(TComponent Component, string Title);