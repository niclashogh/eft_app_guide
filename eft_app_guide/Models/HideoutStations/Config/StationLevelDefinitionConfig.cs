using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace eft_app_guide.Models.HideoutStations.Config
{
    public class StationLevelDefinitionConfig : IEntityTypeConfiguration<StationLevelDefinition>
    {
        public void Configure(EntityTypeBuilder<StationLevelDefinition> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to StationLevel
            builder
                .HasOne(x => x.Station)
                .WithMany(x => x.LevelDefinitions)
                .HasForeignKey(x => x.StationId);

            // Link @ to StationLevelDefintionCrafting
            builder
                .HasMany(x => x.CraftingRelations)
                .WithOne(x => x.StationLevel)
                .HasForeignKey(x => x.StationLevelDefinitionId);
        }
    }
}
