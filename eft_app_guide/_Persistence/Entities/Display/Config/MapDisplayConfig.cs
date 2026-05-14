using eft_app_guide._Persistence.Entities.Display.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.Display.Config
{
    public class MapDisplayConfig : IEntityTypeConfiguration<MapDisplay>
    {
        public void Configure(EntityTypeBuilder<MapDisplay> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.MapDisplays)
                .HasForeignKey(x => x.MapId);

            // Link @ to BtrDisplay
            builder
                .HasMany(x => x.BtrDisplays)
                .WithOne(x => x.MapDisplay)
                .HasForeignKey(x => x.MapDisplayId);

            // Link @ to ChapterTaskDisplay
            builder
                .HasMany(x => x.ChapterTaskDisplays)
                .WithOne(x => x.MapDisplay)
                .HasForeignKey(x => x.MapDisplayId);

            // Link @ to ExtractionDisplay
            builder
                .HasMany(x => x.ExtractionDisplays)
                .WithOne(x => x.MapDisplay)
                .HasForeignKey(x => x.MapDisplayId);

            // Link @ to LocationDisplay
            builder
                .HasMany(x => x.LocationDisplays)
                .WithOne(x => x.MapDisplay)
                .HasForeignKey(x => x.MapDisplayId);

            // Link @ to MarkerDisplay
            builder
                .HasMany(x => x.MarkerDisplays)
                .WithOne(x => x.MapDisplay)
                .HasForeignKey(x => x.MapDisplayId);

            // Link @ to QuestTaskDisplay
            builder
                .HasMany(x => x.QuestTaskDisplays)
                .WithOne(x => x.MapDisplay)
                .HasForeignKey(x => x.MapDisplayId);
        }
    }
}
