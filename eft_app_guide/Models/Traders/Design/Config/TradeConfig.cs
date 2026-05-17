using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Traders.Design.Config
{
    public class TradeConfig : IEntityTypeConfiguration<Trade>
    {
        public void Configure(EntityTypeBuilder<Trade> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Trader
            builder
                .HasOne(x => x.Trader)
                .WithMany(x => x.Trades)
                .HasForeignKey(x => x.TraderId);

            // Link @ to TradePayment
            builder
                .HasMany(x => x.TradePayments)
                .WithOne(x => x.Trade)
                .HasForeignKey(x => x.TradeId);

            // Link @ to TradeResult
            builder
                .HasMany(x => x.TradeResults)
                .WithOne(x => x.Trade)
                .HasForeignKey(x => x.TradeId);
        }
    }
}
