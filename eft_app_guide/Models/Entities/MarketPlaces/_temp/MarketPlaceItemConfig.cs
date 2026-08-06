using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.MarketPlaces._temp
{
    public class MarketPlaceItemConfig : IEntityTypeConfiguration<MarketPlaceItem>
    {
        public void Configure(EntityTypeBuilder<MarketPlaceItem> builder)
        {
            builder.HasKey(x => new { x.MarketPlaceId, x.ItemId });

            // Link @ to MarketPlace
            builder
                .HasOne(x => x.MarketPlace)
                .WithMany(x => x.MarketPlaceItems)
                .HasForeignKey(x => x.MarketPlaceId);

            // Link @ to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.MarketPlaceItems)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
