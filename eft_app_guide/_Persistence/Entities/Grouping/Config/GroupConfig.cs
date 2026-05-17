using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.Grouping.Config
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to GroupType
            builder
                .HasOne(x => x.GroupType)
                .WithMany(x => x.Groups)
                .HasForeignKey(x => x.GroupTypeId);

            // Link @ to QusetGroup
            builder
                .HasMany(x => x.QuestGroups)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId);

            // Link @ to QuestTaskGroup
            builder
                .HasMany(x => x.QuestTaskGroups)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId);

            // Link @ to ChapterTaskGroup
            builder
                .HasMany(x => x.ChapterTaskGroups)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId);

            // Link @ to HumanGroup
            builder
                .HasMany(x => x.HumanGroups)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId);
        }
    }
}
