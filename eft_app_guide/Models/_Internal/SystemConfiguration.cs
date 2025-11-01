using eft_app_guide.Models.Enums;
using System.Windows.Controls;

namespace eft_app_guide.Models._Internal
{
    public class SystemConfiguration
    {
        public MenuPosition MenuPosition { get; set; } = MenuPosition.LeftCenter;
        public Orientation MenuItemOrientation { get; set; } = Orientation.Vertical;
        public bool MenuSlideIn { get; set; } = false;
    }
}
