using eft_app_guide.Models.Extractions.Design;
using eft_app_guide.Models.Extractions.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Extractions.Config
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

            // Link @ to ExtractionRequirement
            builder
                .HasMany(x => x.ExtractionRequirements)
                .WithOne(x => x.Extraction)
                .HasForeignKey(x => x.ExtractionId);

            // Link @ to ExtractionDisplay
            builder
                .HasOne(x => x.ExtractionDisplay)
                .WithOne(x => x.Extraction)
                .HasForeignKey<ExtractionDisplay>(x => x.ExtractionId);

            // Link @ to ExtractionFaction
            builder
                .HasMany(x => x.ExtractionFactions)
                .WithOne(x => x.Extraction)
                .HasForeignKey(x => x.ExtractionId);
        }
    }
}
