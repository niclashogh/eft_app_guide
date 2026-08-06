using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Actors.Design.Config
{
    public class HumanConfig : IEntityTypeConfiguration<Human>
    {
        public void Configure(EntityTypeBuilder<Human> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to HumanLimb
            builder
                .HasMany(x => x.HumanLimbs)
                .WithOne(x => x.Human)
                .HasForeignKey(x => x.HumanId);

            // Link @ to Faction
            builder
                .HasOne(x => x.Faction)
                .WithMany(x => x.Humans)
                .HasForeignKey(x => x.FactionId);

            // Link @ to HumanGroup
            builder
                .HasMany(x => x.HumanGroups)
                .WithOne(x => x.Human)
                .HasForeignKey(x => x.HumanId);

            // Link @ to HumanMap
            builder
                .HasMany(x => x.HumanMaps)
                .WithOne(x => x.Human)
                .HasForeignKey(x => x.HumanId);
        }
    }
}
