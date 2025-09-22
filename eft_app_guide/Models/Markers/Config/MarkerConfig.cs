using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Markers.Config
{
    public class MarkerConfig : IEntityTypeConfiguration<Marker>
    {
        public void Configure(EntityTypeBuilder<Marker> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Marker to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.Markers)
                .HasForeignKey(x => x.MapName);

            // Link Marker to MarkerIcon
            builder
                .HasOne(x => x.MarkerIcon)
                .WithMany(x => x.Markers)
                .HasForeignKey(x => x.MarkerIconId);
        }
    }
}
