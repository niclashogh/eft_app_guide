using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Locations.Config
{
    public class LocationLootConfig : IEntityTypeConfiguration<LocationLoot>
    {
        public void Configure(EntityTypeBuilder<LocationLoot> builder)
        {
            builder.HasKey(x => x.Id);

            // Link LocationLoot to Location
            builder
                .HasOne(x => x.Location)
                .WithMany(x => x.Loot)
                .HasForeignKey(x => x.LocationId);

            // Link LocationLoot to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.LocationLoot)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
