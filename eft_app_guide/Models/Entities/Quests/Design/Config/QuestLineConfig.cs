using eft_app_guide.Models.Entities.Quests.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Quests.Design.Config
{
    public class QuestLineConfig : IEntityTypeConfiguration<QuestLine>
    {
        public void Configure(EntityTypeBuilder<QuestLine> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Quest
            builder
                .HasMany(x => x.Quests)
                .WithOne(x => x.QuestLine)
                .HasForeignKey(x => x.QuestLineId);
        }
    }
}
