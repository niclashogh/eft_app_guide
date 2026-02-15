using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Items.Config
{
    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to ItemCategory
            builder
                .HasOne(x => x.ItemCategory)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.ItemCategoryId);

            // Link @ to CraftingResult
            builder
                .HasMany(x => x.CraftingResults)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);

            // Link @ to CraftingIngredient
            builder
                .HasMany(x => x.CraftingIngredients)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);

            // Link @ to LocationItem
            builder
                .HasMany(x => x.LocationItems)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);

            // Link @ to TradePayment
            builder
                .HasMany(x => x.TradePayments)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);

            // Link @ to TradeResult
            builder
                .HasMany(x => x.TradeResults)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);

            // Link @ to FleaMarketItem
            builder
                .HasMany(x => x.FleaMarketItems)
                .WithOne(x => x.Item)
                .HasForeignKey (x => x.ItemId);
        }
    }
}
