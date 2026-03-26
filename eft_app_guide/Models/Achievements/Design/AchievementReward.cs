using eft_app_guide.Models.Achievements.Config;
using eft_app_guide.Models.Rewards.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Achievements.Design
{
    /// <summary> AssociationEntity (AchievementId + RewardDomainId) </summary>
    [EntityTypeConfiguration(typeof(AchievementRewardConfig))]
    public class AchievementReward
    {
        #region Keys (CompositeKeys)
        [Required] public int AchievementId { get; set; }
        [Required] public int RewardDomainId { get; set; }
        #endregion

        [Required] public int DomainKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public Achievement? Achievement { get; set; }
        public RewardDomain? RewardDomain { get; set; }
        #endregion
    }
}
