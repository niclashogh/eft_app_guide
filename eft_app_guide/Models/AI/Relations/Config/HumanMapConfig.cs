using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.AI.Relations.Config
{
    public class HumanMapConfig : IEntityTypeConfiguration<HumanMap>
    {
        public void Configure(EntityTypeBuilder<HumanMap> builder)
        {
            builder.HasKey(x => new { x.HumanId, x.MapId });

            // Link @ to Human
            builder
                .HasOne(x => x.Human)
                .WithMany(x => x.HumanMaps)
                .HasForeignKey(x => x.HumanId);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.HumanMaps)
                .HasForeignKey(x => x.MapId);
        }
    }
}
