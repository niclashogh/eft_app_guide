using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Locations.Config
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Location to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.Locations)
                .HasForeignKey(x => x.MapId);

            // Link Location to LocationLoot
            builder
                .HasMany(x => x.Items)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);

            // Link Location to LocationAccess
            builder
                .HasMany(x => x.Access)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);

            // Link Location to Container
            builder
                .HasMany(x => x.Containers)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);
        }
    }
}
