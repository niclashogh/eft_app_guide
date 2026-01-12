using eft_app_guide._Persistence.Entities.AuditLogs;
using eft_app_guide.Models.Extractions;
using eft_app_guide.Models.Locations;
using eft_app_guide.Models.Maps;
using eft_app_guide.Models.Markers;
using eft_app_guide.Models.Quests;
using eft_app_guide.Models.Traders;
using Microsoft.EntityFrameworkCore;

namespace eft_app_guide._Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }

        DbSet<Map> Maps { get; set; }
        DbSet<Trader> Traders { get; set; }

        DbSet<Location> AccessKeys { get; set; }
        DbSet<Extraction> Extractions { get; set; }
        DbSet<Marker> Markers { get; set; }
        DbSet<Quest> Quests { get; set; }

        DbSet<AuditLog> AuditLogs { get; set; }
    }
}
