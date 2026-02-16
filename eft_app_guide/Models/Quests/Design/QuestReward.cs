using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Quests.Config;
using eft_app_guide.Models.Rewards.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Design
{
    /// <summary> AssociationEntity (QuestId + RewardDomainId) </summary>
    [EntityTypeConfiguration(typeof(QuestRewardConfig))]
    public class QuestReward : IRewardProvider
    {
        #region Keys
        [Key] public int QuestId { get; init; }
        [Required] public int RewardDomainId { get; set; }
        #endregion

        [Required] public int DomainKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public Quest? Quest { get; set; }
        public RewardDomain? RewardDomain { get; set; }
        #endregion
    }
}
