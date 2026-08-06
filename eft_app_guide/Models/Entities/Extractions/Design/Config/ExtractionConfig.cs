using eft_app_guide.Models.Entities.Extractions.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Extractions.Design.Config
{
    public class ExtractionConfig : IEntityTypeConfiguration<Extraction>
    {
        public void Configure(EntityTypeBuilder<Extraction> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.Extractions)
                .HasForeignKey(x => x.MapId);

            // Link @ to ExtractionDisplay
            builder
                .HasMany(x => x.ExtractionDisplays)
                .WithOne(x => x.Extraction)
                .HasForeignKey(x => x.ExtractionId);

            // Link @ to ExtractionFaction
            builder
                .HasMany(x => x.ExtractionFactions)
                .WithOne(x => x.Extraction)
                .HasForeignKey(x => x.ExtractionId);
        }
    }
}
