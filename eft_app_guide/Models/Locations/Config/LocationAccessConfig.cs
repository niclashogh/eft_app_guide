using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Locations.Config
{
    public class LocationAccessConfig : IEntityTypeConfiguration<LocationAccess>
    {
        public void Configure(EntityTypeBuilder<LocationAccess> builder)
        {
            builder.HasKey(x => x.Id);

            // Link LocationAccess to Location
            builder
                .HasOne(x => x.Location)
                .WithMany(x => x.Access)
                .HasForeignKey(x => x.LocationId);
        }
    }
}
