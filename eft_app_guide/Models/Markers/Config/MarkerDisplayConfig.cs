using eft_app_guide.Models.Markers.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Markers.Config
{
    public class MarkerDisplayConfig : IEntityTypeConfiguration<MarkerDisplay>
    {
        public void Configure(EntityTypeBuilder<MarkerDisplay> builder)
        {
            builder.HasKey(x => x.MarkerId);

            // Link @ to Marker
            builder
                .HasOne(x => x.Marker)
                .WithOne(x => x.MarkerDisplay)
                .HasForeignKey<MarkerDisplay>(x => x.MarkerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Link @ to MarkerIcon
            builder
                .HasOne(x => x.MarkerIcon)
                .WithMany(x => x.MarkerDisplays)
                .HasForeignKey(x => x.MarkerIconId);
        }
    }
}
