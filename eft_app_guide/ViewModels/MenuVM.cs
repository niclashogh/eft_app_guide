using eft_app_guide.Extentions;
using eft_app_guide.Models;
using eft_app_guide.Services;
using eft_app_guide.Views;
using Microsoft.Extensions.DependencyInjection;

namespace eft_app_guide.ViewModels
{
    [DIAutoRegister(ServiceLifetime.Singleton)]
    public class MenuVM : BaseVM
    {
        #region [Time] Variables & Properties
        public string CurrentTime
        {
            get { return DateTime.Now.ToString("HH:mm"); }
        }
        #endregion

        #region [Menu Items] Variables & Properties
        public static List<ViewRecord<Type>> MenuItems { get; } = new List<ViewRecord<Type>>
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

        public MenuVM()
        {
            
        }
    }
}
