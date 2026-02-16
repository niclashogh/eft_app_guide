using eft_app_guide.Models.HideoutStations.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.HideoutStations.Config
{
    internal class StationLevelCraftingConfig : IEntityTypeConfiguration<StationLevelCrafting>
    {
        public void Configure(EntityTypeBuilder<StationLevelCrafting> builder)
        {
            builder.HasKey(x => new { x.StationLevelId, x.CraftingId });

            // Link @ to StaionLevel
            builder
                .HasOne(x => x.StationLevel)
                .WithMany(x => x.StationLevelCraftings)
                .HasForeignKey(x => x.StationLevelId);

            // Link @ to Crafting
            builder
                .HasOne(x => x.Crafting)
                .WithMany(x => x.StationLevelCraftings)
                .HasForeignKey(x => x.CraftingId);
        }
    }
}
