using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Extractions.Config
{
    public class ExtractionDisplayConfig : IEntityTypeConfiguration<ExtractionDisplay>
    {
        public void Configure(EntityTypeBuilder<ExtractionDisplay> builder)
        {
            builder.HasKey(x => x.ExtractionId);

            // Link @ to Extraction
            builder
                .HasOne(x => x.Extraction)
                .WithOne(x => x.Display)
                .HasForeignKey<ExtractionDisplay>(x => x.ExtractionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
