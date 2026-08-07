using eft_app_guide.Models._unfinished.Traders.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models._unfinished.Traders.Design.Config
{
    public class TraderCurrencyConfig : IEntityTypeConfiguration<TraderCurrency>
    {
        public void Configure(EntityTypeBuilder<TraderCurrency> builder)
        {
            builder.HasKey(x => new { x.TraderId, x.CurrencyId });

            // Link @ to Trader
            builder
                .HasOne(x => x.Trader)
                .WithMany(x => x.TraderCurrencies)
                .HasForeignKey(x => x.TraderId);

            // Link @ to Currency
            builder
                .HasOne(x => x.Currency)
                .WithMany(x => x.TraderCurrencies)
                .HasForeignKey(x => x.CurrencyId);
        }
    }
}
