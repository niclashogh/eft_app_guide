using eft_app_guide.Packages.Interface;
using eft_app_guide.Packs.Enums;
using System.Text.Json.Serialization;

namespace eft_app_guide.Packages.Display
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "Type")]
    [JsonDerivedType(typeof(DisplayTargetElementDefault), "Target")]
    [JsonDerivedType(typeof(DisplayCustomElementDefault), "Custom")]
    public abstract record DisplayElementDefault
    {
        public string Icon { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public OutlineVariants Outline { get; set; }
    }

    public record DisplayTargetElementDefault : DisplayElementDefault
    {
        public DisplayTargetType TargetType { get; set; }
    }

    public record DisplayCustomElementDefault : DisplayElementDefault
    {
        public string Group {  get; set; }
    }
}
