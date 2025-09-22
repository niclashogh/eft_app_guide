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
                .HasForeignKey(x => x.MapName);

            // Link Extraction to ExtractionRequirement
            builder
                .HasMany(x => x.ExtractionRequirements)
                .WithOne(x => x.Extraction)
                .HasForeignKey(x => x.ExtractionId);
        }
    }
}
