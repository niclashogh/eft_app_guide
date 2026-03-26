using eft_app_guide._Persistence.Entities.AuditLogs;
using eft_app_guide._Persistence.Entities.Display;
using eft_app_guide.Models.Extractions.Design;
using eft_app_guide.Models.Locations.Design;
using eft_app_guide.Models.Maps.Design;
using eft_app_guide.Models.Quests.Design;
using eft_app_guide.Models.Traders.Design;
using Microsoft.EntityFrameworkCore;

namespace eft_app_guide._Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }

        DbSet<Map> Maps { get; set; }
        DbSet<Trader> Traders { get; set; }

        DbSet<Location> AccessKeys { get; set; }
        DbSet<Extraction> Extractions { get; set; }
        DbSet<MarkerDisplay> MarkerDisplay { get; set; }
        DbSet<Quest> Quests { get; set; }

        DbSet<AuditLog> AuditLogs { get; set; }
    }
}
