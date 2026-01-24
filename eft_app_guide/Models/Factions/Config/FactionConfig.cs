using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Factions.Config
{
    public class FactionConfig : IEntityTypeConfiguration<Faction>
    {
        public void Configure(EntityTypeBuilder<Faction> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Character
            builder
                .HasMany(x => x.Characters)
                .WithOne(x => x.Faction)
                .HasForeignKey(x => x.FactionId);

            // Link @ to ExtractionFaction
            builder
                .HasMany(x => x.ExtractionRelations)
                .WithOne(x => x.Faction)
                .HasForeignKey(x => x.FactionId);
        }
    }
}
