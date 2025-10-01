using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace eft_app_guide.Services
{
    public static class WindowManager
    {
        /// <summary>
        /// Attempts to open/show a window of <Type>
        /// </summary>
        public static async Task ShowAsync(Type type)
        {
            Window? windowOfType = Application.Current.Windows.OfType<Window>().FirstOrDefault(x => x.GetType() == type);
            if (windowOfType == null)
            {
                Window? newWindow = (Window)ActivatorUtilities.CreateInstance(App.ServiceProvider, type);
                newWindow.Show();
            }
            else
            {
                if (windowOfType!.WindowState == WindowState.Minimized) windowOfType.WindowState = WindowState.Normal;
                else windowOfType.Activate();
            }
        }

        /// <summary>
        /// Attempts to open/show a window of <Generic>
        /// </summary>
        public static async Task ShowAsync<T>() where T : Window => await ShowAsync(typeof(T));
    }
}
