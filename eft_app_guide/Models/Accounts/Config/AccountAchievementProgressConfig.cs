using eft_app_guide.Models.Accounts.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Accounts.Config
{
    public class AccountAchievementProgressConfig : IEntityTypeConfiguration<AccountAchievementProgress>
    {
        public void Configure(EntityTypeBuilder<AccountAchievementProgress> builder)
        {
            builder.HasKey(x => new { x.AccountId, x.AchievementId });

            // Link @ to Account
            builder
                .HasOne(x => x.Account)
                .WithMany(x => x.AccountAchievementProgressions)
                .HasForeignKey(x => x.AccountId);

            // Link @ to Achievement
            builder
                .HasOne(x => x.Achievement)
                .WithMany(x => x.AccountAchievementProgressions)
                .HasForeignKey(x => x.AchievementId);
        }
    }
}
