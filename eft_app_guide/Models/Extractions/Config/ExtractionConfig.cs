using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Extractions.Config
{
    public class ExtractionConfig : IEntityTypeConfiguration<Extraction>
    {
        public void Configure(EntityTypeBuilder<Extraction> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Extraction to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.Extractions)
                .HasForeignKey(x => x.MapId);

            // Link Extraction to ExtractionRequirement
            builder
                .HasMany(x => x.Requirements)
                .WithOne(x => x.Extraction)
                .HasForeignKey(x => x.ExtractionId);

            // Link Extraction to ExtractionDisplay
            builder
                .HasOne(x => x.Display)
                .WithOne(x => x.Extraction)
                .HasForeignKey<ExtractionDisplay>(x => x.ExtractionId);

            // Link Extraction to ExtractionFaction
            builder
                .HasMany(x => x.ExtractionFactions)
                .WithOne(x => x.Extraction)
                .HasForeignKey(x => x.ExtractionId);
        }
    }
}
