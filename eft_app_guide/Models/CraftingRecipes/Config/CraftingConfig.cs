using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.CraftingRecipes.Config
{
    public class CraftingConfig : IEntityTypeConfiguration<Crafting>
    {
        public void Configure(EntityTypeBuilder<Crafting> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.Craftings)
                .HasForeignKey(x => x.ItemId);

            // Link @ to CraftingItem
            builder
                .HasMany(x => x.CraftingItems)
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
