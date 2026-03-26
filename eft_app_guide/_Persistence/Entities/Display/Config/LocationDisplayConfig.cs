using eft_app_guide._Persistence.Entities.Display.Poi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.Display.Config
{
    public class LocationDisplayConfig : IEntityTypeConfiguration<LocationDisplay>
    {
        public void Configure(EntityTypeBuilder<LocationDisplay> builder) // TODO + MapDisplay
        {
            builder.HasKey(x => x.LocationId);

            // Link @ to Location
            builder
                .HasOne(x => x.Location)
                .WithMany(x => x.LocationDisplays)
                .HasForeignKey(x => x.LocationId);
        }
    }
}
