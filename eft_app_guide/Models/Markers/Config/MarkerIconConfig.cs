using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Markers.Config
{
    public class MarkerIconConfig : IEntityTypeConfiguration<MarkerIcon>
    {
        public void Configure(EntityTypeBuilder<MarkerIcon> builder)
        {
            builder.HasKey(x => x.Id);

            // Link MarkerIcon to Marker
            builder
                .HasMany(x => x.Markers)
                .WithOne(x => x.Icon)
                .HasForeignKey(x => x.MarkerIconId);
        }
    }
}
