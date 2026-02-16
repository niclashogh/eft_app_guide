using eft_app_guide.Models.CraftingRecipes.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.CraftingRecipes.Config
{
    public class CraftingIngredientConfig : IEntityTypeConfiguration<CraftingIngredient>
    {
        public void Configure(EntityTypeBuilder<CraftingIngredient> builder)
        {
            builder.HasKey(x => new { x.CraftingId, x.ItemId });

            // Link @ to Crafting
            builder
                .HasOne(x => x.Crafting)
                .WithMany(x => x.CraftingIngredients)
                .HasForeignKey(x => x.CraftingId);

            // Link @ to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.CraftingIngredients)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
