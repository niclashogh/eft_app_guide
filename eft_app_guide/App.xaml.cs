using eft_app_guide.Services;
using eft_app_guide.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.IO;
using System.Reflection;
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
            ServiceCollection services = new();

            string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EFT GUIDE");
            Directory.CreateDirectory(appDataFolder);

            services.AddDbContextFactory<DataContext>(opt =>
            {
                opt.UseSqlite($"Data Source={Path.Combine(appDataFolder, "version_1.db")}");
            });
            
            Assembly assembly = typeof(App).Assembly;
            foreach (Type type in assembly.GetTypes())
            {
                DIAutoRegisterAttribute? attr = type.GetCustomAttribute<DIAutoRegisterAttribute>();
                if (attr == null) continue;
                services.Add(new ServiceDescriptor(type, type, attr.Lifetime));
            }

            ServiceProvider = services.BuildServiceProvider();
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
