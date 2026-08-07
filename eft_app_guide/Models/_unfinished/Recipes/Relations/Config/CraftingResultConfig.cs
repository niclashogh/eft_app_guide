using eft_app_guide.Models._unfinished.Recipes.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models._unfinished.Recipes.Relations.Config
{
    public class CraftingResultConfig : IEntityTypeConfiguration<CraftingResult>
    {
        public void Configure(EntityTypeBuilder<CraftingResult> builder)
        {
            builder.HasKey(x => new { x.CraftingId, x.ItemId });

            // Link @ to Crafting
            builder
                .HasOne(x => x.Crafting)
                .WithMany(x => x.CraftingResults)
                .HasForeignKey(x => x.CraftingId);

            // Link @ to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.CraftingResults)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
