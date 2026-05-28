using eft_app_guide._Objects.Enums;
using System.Windows.Controls;

namespace eft_app_guide._Persistence.Entities.Configurations
{
    public class SystemConfiguration
    {
        public MenuPosition MenuPosition { get; set; } = MenuPosition.LeftCenter;
        public Orientation MenuItemOrientation { get; set; } = Orientation.Vertical;
        public bool MenuSlideIn { get; set; } = false;
    }
}
