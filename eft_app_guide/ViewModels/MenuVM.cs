using eft_app_guide._Attributes;
using eft_app_guide._Objects.Records;
using eft_app_guide.Configurations.Enums;
using eft_app_guide.Services;
using eft_app_guide.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;

namespace eft_app_guide.ViewModels
{
    [DependencyInjectionRegister(ServiceLifetime.Singleton)]
    public class MenuVM : BaseVM
    {
        #region [Time] Variables & Properties
        public string CurrentTime
        {
            get { return DateTime.Now.ToString("HH:mm"); }
        }
        #endregion

        #region [Menu Items] Variables & Properties
        public List<ViewRecord<Type>> MenuItems { get; } = new List<ViewRecord<Type>>
        {
            new(typeof(MapWindow), "Map"),
            new(typeof(SearchWindow), "Search"),
            new(typeof(BrowserWindow), "Browser"),
            new(typeof(SettingWindow), "Setting"),
        };

        public ViewRecord<Type> SelectedItem
        {
            get { return new(); }
            set { _ = WindowManager.ShowAsync(value.Component); }
        }
        #endregion

        #region [UI Configurations] Variables & Properties
        public MenuPosition MenuPosition { get; init; }
        public Orientation MenuItemOrientation { get; init; }
        public bool MenuSlideIn { get; init; }
        #endregion

        public MenuVM()
        {
            MenuPosition = SystemConfigurationManager.GetValue(x => x.MenuPosition);
            MenuItemOrientation = SystemConfigurationManager.GetValue(x => x.MenuItemOrientation);
            MenuSlideIn = SystemConfigurationManager.GetValue(x => x.MenuSlideIn);
        }
    }
}
