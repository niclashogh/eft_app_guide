using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestRequirementConfig : IEntityTypeConfiguration<QuestRequirement>
    {
        public void Configure(EntityTypeBuilder<QuestRequirement> builder)
        {
            builder.HasKey(x => x.Id);

            // Link QuestRequirement to Quest
            builder
                .HasOne(x => x.Quest)
                .WithMany(x => x.QuestRequirements)
                .HasForeignKey(x => x.QuestId);
        }
    }
}
