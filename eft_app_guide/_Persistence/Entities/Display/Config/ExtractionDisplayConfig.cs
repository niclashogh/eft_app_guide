using eft_app_guide._Persistence.Entities.Display.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.Display.Config
{
    public class ExtractionDisplayConfig : IEntityTypeConfiguration<ExtractionDisplay>
    {
        public void Configure(EntityTypeBuilder<ExtractionDisplay> builder)
        {
            builder.HasKey(x => x.ExtractionId);

            // Link @ to Extraction
            builder
                .HasOne(x => x.Extraction)
                .WithMany(x => x.ExtractionDisplays)
                .HasForeignKey(x => x.ExtractionId);

            // Link @ to MapDisplay
            builder
                .HasOne(x => x.MapDisplay)
                .WithMany(x => x.ExtractionDisplays)
                .HasForeignKey(x => x.MapDisplayId);
        }
    }
}
