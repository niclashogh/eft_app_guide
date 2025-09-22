using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestLineConfig : IEntityTypeConfiguration<QuestLine>
    {
        public void Configure(EntityTypeBuilder<QuestLine> builder)
        {
            builder.HasKey(x => x.Id);

            // Link QuestLine to Quest
            builder
                .HasMany(x => x.Quests)
                .WithOne(x => x.QuestLine)
                .HasForeignKey(x => x.QuestLineId);
        }
    }
}
