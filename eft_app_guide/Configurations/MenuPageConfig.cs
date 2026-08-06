using eft_app_guide.Configurations.Enums;
using System.Windows.Controls;

namespace eft_app_guide.Configurations
{
    public class MenuPageConfig
    {
        public MenuPosition MenuPosition { get; set; } = MenuPosition.LeftCenter;
        public Orientation MenuItemOrientation { get; set; } = Orientation.Vertical;
        public bool MenuSlideIn { get; set; } = false;
    }
}
