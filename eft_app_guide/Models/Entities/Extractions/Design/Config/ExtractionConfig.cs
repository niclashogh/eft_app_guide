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
        }
    }
}
