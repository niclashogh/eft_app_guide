using eft_app_guide.Models.AccessKeys;
using eft_app_guide.Models.Entities;
using eft_app_guide.Models.Extractions;
using eft_app_guide.Models.Markers;
using eft_app_guide.Models.Quests;
using Microsoft.EntityFrameworkCore;

namespace eft_app_guide
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }

        DbSet<Map> Maps { get; set; }
        DbSet<Trader> Traders { get; set; }

        DbSet<AccessKey> AccessKeys { get; set; }
        DbSet<Extraction> Extractions { get; set; }
        DbSet<Marker> Markers { get; set; }
        DbSet<Quest> Quests { get; set; }
    }
}
