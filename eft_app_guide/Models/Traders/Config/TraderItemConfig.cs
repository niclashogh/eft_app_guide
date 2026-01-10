using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Traders.Config
{
    public class TraderItemConfig : IEntityTypeConfiguration<TraderItem>
    {
        public void Configure(EntityTypeBuilder<TraderItem> builder)
        {
            builder.HasKey(x => x.Id);

            // Link TraderItem to Trader
            builder
                .HasOne(x => x.Trader)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.TraderId);

            // Link TraderItem to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.TraderItems)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
