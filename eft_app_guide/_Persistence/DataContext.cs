using eft_app_guide._Objects.ValueObjects;
using eft_app_guide._Objects.ValueObjects.Converters;
using eft_app_guide.Models._unfinished.Traders.Design;
using eft_app_guide.Models.AuditLogs;
using eft_app_guide.Models.Entities.Maps.Design;
using Microsoft.EntityFrameworkCore;

namespace eft_app_guide._Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .Properties<Percent>()
                .HaveConversion<PercentConverter>();

            configurationBuilder
                .Properties<GameTime>()
                .HaveConversion<GameTimeConverter>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }

        DbSet<Map> Maps { get; set; }
        DbSet<Trader> Traders { get; set; }
        // ...

        DbSet<AuditLog> AuditLogs { get; set; }
    }
}
