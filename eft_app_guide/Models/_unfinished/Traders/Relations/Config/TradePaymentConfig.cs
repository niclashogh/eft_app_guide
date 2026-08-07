using eft_app_guide.Models._unfinished.Traders.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models._unfinished.Traders.Relations.Config
{
    public class TradePaymentConfig : IEntityTypeConfiguration<TradePayment>
    {
        public void Configure(EntityTypeBuilder<TradePayment> builder)
        {
            builder.HasKey(x => new { x.TradeId, x.ItemId });

            // Link @ to Trade
            builder
                .HasOne(x => x.Trade)
                .WithMany(x => x.TradePayments)
                .HasForeignKey(x => x.TradeId);

            // Link @ to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.TradePayments)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
