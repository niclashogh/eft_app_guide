using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Maps.Config
{
    public class MapConfig : IEntityTypeConfiguration<Map>
    {
        public void Configure(EntityTypeBuilder<Map> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Map to Location
            builder
                .HasMany(x => x.Locations)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link Map to Extraction
            builder
                .HasMany(x => x.Extractions)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link Map to QuestTask
            builder
                .HasMany(x => x.QuestTasks)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link Map to BTR
            builder
                .HasMany(x => x.BTRs)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link Map to Marker
            builder
                .HasMany(x => x.Markers)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);
        }
    }
}
