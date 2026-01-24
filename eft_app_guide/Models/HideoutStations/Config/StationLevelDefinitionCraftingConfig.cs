using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.HideoutStations.Config
{
    internal class StationLevelDefinitionCraftingConfig : IEntityTypeConfiguration<StationLevelDefinitionCrafting>
    {
        public void Configure(EntityTypeBuilder<StationLevelDefinitionCrafting> builder)
        {
            builder.HasKey(x => new { x.StationLevelDefinitionId, x.CraftingId });

            // Link @ to StaionLevelDefinition
            builder
                .HasOne(x => x.StationLevel)
                .WithMany(x => x.CraftingRelations)
                .HasForeignKey(x => x.StationLevelDefinitionId);

            // Link @ to Crafting
            builder
                .HasOne(x => x.Crafting)
                .WithMany(x => x.StationLevelRelations)
                .HasForeignKey(x => x.CraftingId);
        }
    }
}
