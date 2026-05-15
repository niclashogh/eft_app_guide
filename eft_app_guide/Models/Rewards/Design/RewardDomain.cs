using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Accounts.Design;
using eft_app_guide.Models.Achievements.Design;
using eft_app_guide.Models.Chapters.Design;
using eft_app_guide.Models.Rewards.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Rewards.Design
{
    /// <summary><b>DefintionEntity</b></summary>
    [EntityTypeConfiguration(typeof(RewardDomainConfig))]
    public class RewardDomain // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        /// <summary> Domain of which the reward originates from. Item, Currency, etc. </summary>
        [Required] public string Domain {  get; set; }

        #region Relations (Children)
        public AssociationList<AccountEditionReward> AccountEditionRewards { get; set; } = [];
        public AssociationList<ChapterTaskReward> ChapterTaskRewards { get; set; } = [];
        public AssociationList<AchievementReward> AchievementRewards { get; set; } = [];
        // TODO AssociationList<QuestReward> ...
        #endregion
    }
}
