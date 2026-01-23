using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Extractions.Config
{
    public class ExtractionFactionConfig : IEntityTypeConfiguration<ExtractionFaction>
    {
        public void Configure(EntityTypeBuilder<ExtractionFaction> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasIndex(x => new { x.ExtractionId, x.FactionId })
                .IsUnique();

            // Link ExtractionFaction to Extraction
            builder
                .HasOne(x => x.Extraction)
                .WithMany(x => x.ExtractionFactions)
                .HasForeignKey(x => x.ExtractionId);

            // Link ExtractionFaction to Faction
            builder
                .HasOne(x => x.Faction)
                .WithMany(x => x.ExtractionFactions)
                .HasForeignKey(x => x.FactionId);
        }
    }
}
