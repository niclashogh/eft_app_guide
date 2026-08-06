using eft_app_guide._Persistence;
using eft_app_guide.Extentions;
using eft_app_guide.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace eft_app_guide
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            #region Adding Services
            ServiceCollection service = new();

            StorageDirectory.CreateDirectory();
            DatabaseSetup.AddContextFactory(service);
            service.AddDependencyInjections();

            ServiceProvider = service.BuildServiceProvider();
            #endregion

            DatabaseSetup.Initialize(ServiceProvider);

            MenuWindow menuWindow = ServiceProvider.GetRequiredService<MenuWindow>();
            menuWindow.Show();
        }
    }
}
