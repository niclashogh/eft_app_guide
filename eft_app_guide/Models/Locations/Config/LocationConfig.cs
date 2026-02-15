using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Locations.Config
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.Locations)
                .HasForeignKey(x => x.MapId);

            // Link @ to LocationItem
            builder
                .HasMany(x => x.LocationItems)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);

            // Link @ to LocationAccess
            builder
                .HasMany(x => x.LocationAccesses)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);

            // Link @ to Container
            builder
                .HasMany(x => x.Containers)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);
        }
    }
}
