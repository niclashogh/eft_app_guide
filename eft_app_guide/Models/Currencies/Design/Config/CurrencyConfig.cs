using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Currencies.Design.Config
{
    public class CurrencyConfig : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to CurrencyExchange
            builder
                .HasMany(x => x.CurrencyExchanges)
                .WithOne(x => x.FromCurrency)
                .HasForeignKey(x => x.FromCurrencyId);

            // Link @ to TraderLevel
            builder
                .HasMany(x => x.TraderLevels)
                .WithOne(x => x.Currency)
                .HasForeignKey(x => x.CurrencyId);
        }
    }
}
