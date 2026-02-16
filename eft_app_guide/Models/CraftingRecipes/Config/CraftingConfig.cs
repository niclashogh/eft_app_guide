using eft_app_guide.Models.CraftingRecipes.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.CraftingRecipes.Config
{
    public class CraftingConfig : IEntityTypeConfiguration<Crafting>
    {
        public void Configure(EntityTypeBuilder<Crafting> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to CraftingResult
            builder
                .HasMany(x => x.CraftingResults)
                .WithOne(x => x.Crafting)
                .HasForeignKey(x => x.CraftingId);

            // Link @ to CraftingIngredient
            builder
                .HasMany(x => x.CraftingIngredients)
                .WithOne(x => x.Crafting)
                .HasForeignKey(x => x.CraftingId);

            // Link @ to StationLevelCrafting
            builder
                .HasMany(x => x.StationLevelCraftings)
                .WithOne(x => x.Crafting)
                .HasForeignKey(x => x.StationLevelId);
        }
    }
}
