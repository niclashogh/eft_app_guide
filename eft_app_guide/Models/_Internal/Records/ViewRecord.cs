namespace eft_app_guide.Models._Internal.Records;

public readonly record struct ViewRecord<TComponent>(TComponent Component, string Title);