using eft_app_guide.Models.Locations.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Locations.Config
{
    public class LocationAccessConfig : IEntityTypeConfiguration<LocationAccess>
    {
        public void Configure(EntityTypeBuilder<LocationAccess> builder)
        {
            builder.HasKey(x => new { x.LocationId, x.AccessKeyId });

            // Link @ to Location
            builder
                .HasOne(x => x.Location)
                .WithMany(x => x.LocationAccesses)
                .HasForeignKey(x => x.LocationId);

            // Link @ to AccessKey
            builder
                .HasOne(x => x.AccessKey)
                .WithMany(x => x.LocationAccesses)
                .HasForeignKey(x => x.AccessKeyId);
        }
    }
}
