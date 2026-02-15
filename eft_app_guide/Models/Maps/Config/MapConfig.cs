using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Maps.Config
{
    public class MapConfig : IEntityTypeConfiguration<Map>
    {
        public void Configure(EntityTypeBuilder<Map> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Location
            builder
                .HasMany(x => x.Locations)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link @ to Extraction
            builder
                .HasMany(x => x.Extractions)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link @ to Btr
            builder
                .HasMany(x => x.Btrs)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link @ to Marker
            builder
                .HasMany(x => x.Markers)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link @ to ChapterTaskMap
            builder
                .HasMany(x => x.ChapterTaskMaps)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link @ to QuestTaskMap
            builder
                .HasMany(x => x.QuestTasksMaps)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);

            // Link @ to CharacterMapAccess
            builder
                .HasMany(x => x.CharacterMapAccesses)
                .WithOne(x => x.Map)
                .HasForeignKey(x => x.MapId);
        }
    }
}
