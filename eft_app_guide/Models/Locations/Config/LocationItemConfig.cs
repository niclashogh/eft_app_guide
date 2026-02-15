using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Locations.Config
{
    public class LocationItemConfig : IEntityTypeConfiguration<LocationItem>
    {
        public void Configure(EntityTypeBuilder<LocationItem> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Location
            builder
                .HasOne(x => x.Location)
                .WithMany(x => x.LocationItems)
                .HasForeignKey(x => x.LocationId);

            // Link @ to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.LocationItems)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
