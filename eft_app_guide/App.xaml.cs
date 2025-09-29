using eft_app_guide.Extentions;
using eft_app_guide.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;

namespace eft_app_guide
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;
        public readonly static string ROOT_DATA_FOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EFT GUIDE");
        public readonly static string ROOT_ASSET_FOLDER = Path.Combine(ROOT_DATA_FOLDER, "Assets");

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            #region Adding Services
            ServiceCollection service = new();

            Directory.CreateDirectory(ROOT_DATA_FOLDER);

            service.AddDbContextFactory<DataContext>(opt =>
            {
                opt.UseSqlite($"Data Source={Path.Combine(ROOT_DATA_FOLDER, "version_1.db")}");
            });

            service.AddDependencyInjections();

            ServiceProvider = service.BuildServiceProvider();
            #endregion

            #region Register Database
            using IServiceScope scope = ServiceProvider.CreateScope();
            IDbContextFactory<DataContext> factory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<DataContext>>();

            using DataContext context = factory.CreateDbContext();
            context.Database.EnsureCreated();
            #endregion

            MenuWindow menuWindow = ServiceProvider.GetRequiredService<MenuWindow>();
            menuWindow.Show();
        }
    }
}
