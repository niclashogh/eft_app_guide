using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Currency.Config
{
    public class CurrencyExchangeConfig : IEntityTypeConfiguration<CurrencyExchange>
    {
        public void Configure(EntityTypeBuilder<CurrencyExchange> builder)
        {
            builder.HasKey(x => new { x.FromCurrency, x.ToCurrency });

            // Link @ to FromCurrency
            builder
                .HasOne(x => x.FromCurrency)
                .WithMany()
                .HasForeignKey(x => x.FromCurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            // Link @ to ToCurrency
            builder
                .HasOne(x => x.ToCurrency)
                .WithMany()
                .HasForeignKey(x => x.ToCurrencyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
