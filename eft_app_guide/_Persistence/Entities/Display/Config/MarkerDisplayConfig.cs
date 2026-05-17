using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.Display.Config
{
    public class MarkerDisplayConfig : IEntityTypeConfiguration<MarkerDisplay>
    {
        public void Configure(EntityTypeBuilder<MarkerDisplay> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to MapDisplay
            builder
                .HasOne(x => x.MapDisplay)
                .WithMany(x => x.MarkerDisplays)
                .HasForeignKey(x => x.MapDisplayId);
        }
    }
}
