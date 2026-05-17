using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Raids.Design.Config
{
    public class RaidConfig : IEntityTypeConfiguration<Raid>
    {
        public void Configure(EntityTypeBuilder<Raid> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.Raids)
                .HasForeignKey(x => x.MapId);

            // Link @ to CharacterRaid
            builder
                .HasMany(x => x.CharacterRaids)
                .WithOne(x => x.Raid)
                .HasForeignKey(x => x.RaidId);
        }
    }
}
