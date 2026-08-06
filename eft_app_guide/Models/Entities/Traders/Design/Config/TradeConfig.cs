using eft_app_guide.Models.Entities.Traders.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Traders.Design.Config
{
    public class TradeConfig : IEntityTypeConfiguration<Trade>
    {
        public void Configure(EntityTypeBuilder<Trade> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to TraderLevel
            builder
                .HasOne(x => x.TraderLevel)
                .WithMany(x => x.Trades)
                .HasForeignKey(x => x.TraderLevelId);

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
