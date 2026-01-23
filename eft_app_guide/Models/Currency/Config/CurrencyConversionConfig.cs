using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Currency.Config
{
    public class CurrencyConversionConfig : IEntityTypeConfiguration<CurrencyConversion>
    {
        public void Configure(EntityTypeBuilder<CurrencyConversion> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasIndex(x => new { x.FromCurrency, x.ToCurrency })
                .IsUnique();

            builder
                .HasOne(x => x.FromCurrency)
                .WithMany()
                .HasForeignKey(x => x.FromCurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.ToCurrency)
                .WithMany()
                .HasForeignKey(x => x.ToCurrencyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
