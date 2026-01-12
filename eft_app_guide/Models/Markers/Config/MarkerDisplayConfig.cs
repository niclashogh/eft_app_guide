using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Markers.Config
{
    public class MarkerDisplayConfig : IEntityTypeConfiguration<MarkerDisplay>
    {
        public void Configure(EntityTypeBuilder<MarkerDisplay> builder)
        {
            builder.HasKey(x => x.MarkerId);

            // Link MarkerDisplay to Marker
            builder
                .HasOne(x => x.Marker)
                .WithOne(x => x.Display)
                .HasForeignKey<MarkerDisplay>(x => x.MarkerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Link MakerDisplay to MarkerIcon
            builder
                .HasOne(x => x.Icon)
                .WithMany(x => x.MarkerDisplays)
                .HasForeignKey(x => x.MarkerIconId);
        }
    }
}
