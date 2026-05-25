using eft_app_guide._Persistence.Entities.TargetTypes;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Achievements.Design;
using eft_app_guide.Models.Achievements.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Achievements.Relations
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// AchievementId
    /// RewardDomainId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(AchievementRewardConfig))]
    public class AchievementReward : IRewardProvider
    {
        #region Keys (CompositeKeys)
        [Required] public int AchievementId { get; set; }
        [Required] public int RewardTargetTypeId { get; set; }
        #endregion

        [Required] public int TargetKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public Achievement? Achievement { get; set; }
        public RewardTargetType? RewardTargetType { get; set; }
        #endregion
    }
}
