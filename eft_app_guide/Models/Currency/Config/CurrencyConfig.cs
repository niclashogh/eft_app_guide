using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Currency.Config
{
    public class CurrencyConfig : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Currency to CurrencyConversion
            builder
                .HasMany(x => x.Conversions)
                .WithOne(x => x.FromCurrency)
                .HasForeignKey(x => x.FromCurrencyId);
        }
    }
}
