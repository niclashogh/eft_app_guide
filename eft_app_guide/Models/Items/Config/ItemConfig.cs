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

            // Link @ to Crafting
            builder
                .HasMany(x => x.Craftings)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);

            // Link @ to CraftingItem
            builder
                .HasMany(x => x.CraftingItems)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);

            // Link @ to LocationItem
            builder
                .HasMany(x => x.LocationItems)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);

            // Link @ to TraderItem
            builder
                .HasMany(x => x.TraderItems)
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
