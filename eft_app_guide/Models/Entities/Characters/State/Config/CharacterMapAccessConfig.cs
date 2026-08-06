using eft_app_guide.Models.Entities.Characters.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Characters.State.Config
{
    public class CharacterMapAccessConfig : IEntityTypeConfiguration<CharacterMapAccess>
    {
        public void Configure(EntityTypeBuilder<CharacterMapAccess> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.MapId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterMapAccesses)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.CharacterMapAccesses)
                .HasForeignKey(x => x.MapId);
        }
    }
}
