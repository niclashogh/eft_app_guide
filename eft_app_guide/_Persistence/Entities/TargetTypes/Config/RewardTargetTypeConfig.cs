using eft_app_guide._Persistence.Entities.TargetTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.TargetTypes.Config
{
    public class RewardTargetTypeConfig : IEntityTypeConfiguration<RewardTargetType>
    {
        public void Configure(EntityTypeBuilder<RewardTargetType> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to AccountEditionReward
            builder
                .HasMany(x => x.AccountEditionRewards)
                .WithOne(x => x.RewardTargetType)
                .HasForeignKey(x => x.RewardTargetTypeId);

            // Link @ to ChapterTaskReward
            builder
                .HasMany(x => x.ChapterTaskRewards)
                .WithOne(x => x.RewardTargetType)
                .HasForeignKey(x => x.RewardTargetTypeId);

            // Link @ to AchievementReward
            builder
                .HasMany(x => x.AchievementRewards)
                .WithOne(x => x.RewardTargetType)
                .HasForeignKey(x => x.RewardTargetTypeId);

            // Link @ to QuestReward
            builder
                .HasMany(x => x.QuestRewards)
                .WithOne(x => x.RewardTargetType)
                .HasForeignKey(x => x.RewardTargetTypeId);
        }
    }
}
