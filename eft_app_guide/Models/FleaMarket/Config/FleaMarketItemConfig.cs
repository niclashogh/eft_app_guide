using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.FleaMarket.Config
{
    public class FleaMarketItemConfig : IEntityTypeConfiguration<FleaMarketItem> // MISSING
    {
        public void Configure(EntityTypeBuilder<FleaMarketItem> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to FleaMarket
            builder
                .HasOne(x => x.FleaMarket)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.FleaMarketId);

            // Link @ to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.FleaMarketItems)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
