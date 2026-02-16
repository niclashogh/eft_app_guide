using eft_app_guide.Models.Locations.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Locations.Config
{
    public class LocationDisplayConfig : IEntityTypeConfiguration<LocationDisplay>
    {
        public void Configure(EntityTypeBuilder<LocationDisplay> builder)
        {
            builder.HasKey(x => x.LocationId);

            // Link @ to Location
            builder
                .HasOne(x => x.Location)
                .WithOne(x => x.LocationDisplay)
                .HasForeignKey<LocationDisplay>(x => x.LocationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
