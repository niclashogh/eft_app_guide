using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Extractions.Config
{
    public class ExtractionRequirementConfig : IEntityTypeConfiguration<ExtractionRequirement>
    {
        public void Configure(EntityTypeBuilder<ExtractionRequirement> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Extraction
            builder
                .HasOne(x => x.Extraction)
                .WithMany(x => x.Requirements)
                .HasForeignKey(x => x.ExtractionId);
        }
    }
}
