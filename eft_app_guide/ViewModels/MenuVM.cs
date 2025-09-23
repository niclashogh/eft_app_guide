using eft_app_guide.Models;
using eft_app_guide.Services;
using eft_app_guide.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

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
            set
            {
                _ = ManageWindow(value.Component);
            }
        }
        #endregion

        public MenuVM()
        {
            
        }

        private async Task ManageWindow(Type type)
        {
            Window? windowOfType = Application.Current.Windows.OfType<Window>().FirstOrDefault(x => x.GetType() == type);
            if (windowOfType == null)
            {
                Window newWindow = (Window)ActivatorUtilities.CreateInstance(App.ServiceProvider, type);
                if (newWindow == null) return;

                newWindow.Show();
            }
            else
            {
                if (windowOfType!.WindowState == WindowState.Minimized) windowOfType.WindowState = WindowState.Normal;
                else windowOfType.Activate();
            }
        }
    }
}
