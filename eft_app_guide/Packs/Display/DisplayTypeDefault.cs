using eft_app_guide.Packages.Interface;
using eft_app_guide.Packs.Enums;

namespace eft_app_guide.Packages.Display
{
    public class DisplayTypeDefault
    {
        public DisplayTargetType TargetType { get; set; }

        public string Icon { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public OutlineVariants Outline { get; set; }
    }
}
