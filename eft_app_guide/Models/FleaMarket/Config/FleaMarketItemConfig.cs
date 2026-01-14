using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.FleaMarket.Config
{
    public class FleaMarketItemConfig : IEntityTypeConfiguration<FleaMarketItem>
    {
        public void Configure(EntityTypeBuilder<FleaMarketItem> builder)
        {
            builder.HasKey(x => x.Id);

            // Link FleaMarketItem to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.FleaMarketItems)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
