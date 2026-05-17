using eft_app_guide._Persistence.Entities.RewardDomain.Config;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Accounts.Relations;
using eft_app_guide.Models.Achievements.Relations;
using eft_app_guide.Models.Chapters.Relations;
using eft_app_guide.Models.Quests.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.RewardDomain
{
    /// <summary><b>DefintionEntity</b></summary>
    [EntityTypeConfiguration(typeof(RewardDomainConfig))]
    public class RewardDomain // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name {  get; set; }

        #region Relations (Children)
        public AssociationList<AccountEditionReward> AccountEditionRewards { get; set; } = [];
        public AssociationList<ChapterTaskReward> ChapterTaskRewards { get; set; } = [];
        public AssociationList<AchievementReward> AchievementRewards { get; set; } = [];
        public AssociationList<QuestReward> QuestRewards { get; set; } = [];
        #endregion
    }
}
