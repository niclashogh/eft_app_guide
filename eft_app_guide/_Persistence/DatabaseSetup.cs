using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace eft_app_guide._Persistence
{
    public static class DatabaseSetup
    {
        private static string DATABASE_NAME = "default";

        public static ServiceCollection AddContextFactory(ServiceCollection service)
        {
            // StorageFolder.EnsureProfilesFile(); ... { "Selected" : { }, "Profiles": [{Name: x, Database: default}, ...] }
            // DATABASE_NAME = StorageFolder.GetSelectedProfile().Database;

            service.AddDbContextFactory<DataContext>((serviceProvider, opt) =>
            {
                string path = Path.Combine(StorageFolder.DATA_FOLDER, DATABASE_NAME + ".db");

                opt.UseSqlite($"Data Source={path}");
                opt.AddInterceptors(new ForeignKeyInterceptor());
            });

            return service;
        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using IServiceScope scope = serviceProvider.CreateScope();
            IDbContextFactory<DataContext> factory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<DataContext>>();

            using DataContext context = factory.CreateDbContext();
            context.Database.EnsureCreated();
        }

        public static void SwitchDatabase(string name)
        {
            DATABASE_NAME = name;
            Initialize(App.ServiceProvider);
        }
    }
}
