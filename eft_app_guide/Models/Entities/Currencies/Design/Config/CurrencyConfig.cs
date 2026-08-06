using eft_app_guide.Models.Entities.Currencies.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Currencies.Design.Config
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

            // Link @ to TraderCurrency
            builder
                .HasMany(x => x.TraderCurrencies)
                .WithOne(x => x.Currency)
                .HasForeignKey(x => x.CurrencyId);
        }
    }
}
