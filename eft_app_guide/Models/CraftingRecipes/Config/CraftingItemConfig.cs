using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.CraftingRecipes.Config
{
    public class CraftingItemConfig : IEntityTypeConfiguration<CraftingItem>
    {
        public void Configure(EntityTypeBuilder<CraftingItem> builder)
        {
            builder.HasKey(x => new { x.Crafting, x.Item });

            // Link @ to Crafting
            builder
                .HasOne(x => x.Crafting)
                .WithMany(x => x.CraftingItems)
                .HasForeignKey(x => x.CraftingId);

            // Link @ to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.CraftingItems)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
