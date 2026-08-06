using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Actors.Relations.Config
{
    public class HumanGroupConfig : IEntityTypeConfiguration<HumanGroup>
    {
        public void Configure(EntityTypeBuilder<HumanGroup> builder)
        {
            builder.HasKey(x => new { x.HumanId, x.GroupId });

            // Link @ to Human
            builder
                .HasOne(x => x.Human)
                .WithMany(x => x.HumanGroups)
                .HasForeignKey(x => x.HumanId);

            // Link @ to Group
            builder
                .HasOne(x => x.Group)
                .WithMany(/* NOT DECLARED TO DECLUTTER Group */)
                .HasForeignKey(x => x.GroupId);
        }
    }
}
