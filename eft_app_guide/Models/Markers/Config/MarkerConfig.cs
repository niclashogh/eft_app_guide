using eft_app_guide.Models.Markers.Design;
using eft_app_guide.Models.Markers.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Markers.Config
{
    public class MarkerConfig : IEntityTypeConfiguration<Marker>
    {
        public void Configure(EntityTypeBuilder<Marker> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.Markers)
                .HasForeignKey(x => x.MapId);

            // Link @ to MarkerDisplay
            builder
                .HasOne(x => x.MarkerDisplay)
                .WithOne(x => x.Marker)
                .HasForeignKey<MarkerDisplay>(x => x.MarkerId);
        }
    }
}
