using eft_app_guide._Persistence.Entities.TargetTypes;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Quests.Design;
using eft_app_guide.Models.Quests.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Relations
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// QuestId
    /// RewardDomainId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(QuestRewardConfig))]
    public class QuestReward : IRewardProvider
    {
        #region Keys
        [Key] public int QuestId { get; init; }
        [Required] public int RewardTargetTypeId { get; set; }
        #endregion

        [Required] public int TargetKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public Quest? Quest { get; set; }
        public RewardTargetType? RewardTargetType { get; set; }
        #endregion
    }
}
