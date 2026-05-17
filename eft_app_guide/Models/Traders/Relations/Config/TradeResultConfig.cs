using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Traders.Relations.Config
{
    public class TradeResultConfig : IEntityTypeConfiguration<TradeResult>
    {
        public void Configure(EntityTypeBuilder<TradeResult> builder)
        {
            builder.HasKey(x => new { x.TradeId, x.ItemId });

            // Link @ to Trade
            builder
                .HasOne(x => x.Trade)
                .WithMany(x => x.TradeResults)
                .HasForeignKey(x => x.TradeId);

            // Link @ to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.TradeResults)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
