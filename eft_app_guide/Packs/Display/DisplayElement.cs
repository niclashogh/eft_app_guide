using eft_app_guide.Packages.Interface;
using eft_app_guide.Packs.Enums;
using System.Text.Json.Serialization;

namespace eft_app_guide.Packages.Display
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "Type")]
    [JsonDerivedType(typeof(DisplayTargetElement), "Target")]
    [JsonDerivedType(typeof(DisplayCustomElement), "Custom")]
    public abstract record DisplayElement
    {
        public double? X { get; set; }
        public double? Y { get; set; }

        public string? Icon { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }

        public OutlineVariants? Outline { get; set; }
    }

    public record DisplayTargetElement : DisplayElement
    {
        public DisplayTargetType TargetType { get; set; }
        public int TargetKey { get; set; }
    }

    public record DisplayCustomElement : DisplayElement
    {
        public string Group {  get; set; }
        public string Description { get; set; }
    }
}