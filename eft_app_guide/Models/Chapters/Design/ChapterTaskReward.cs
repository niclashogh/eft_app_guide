using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Chapters.Config;
using eft_app_guide.Models.Rewards.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Design
{
    /// <summary> AssociationEntity (ChapterTaskId + RewardDomainId) </summary>
    [EntityTypeConfiguration(typeof(ChapterTaskRewardConfig))]
    public class ChapterTaskReward : IRewardProvider
    {
        #region Keys (CompositeKeys)
        [Required] public int ChapterTaskId { get; set; }
        [Required] public int RewardDomainId { get; set; }
        #endregion

        [Required] public int DomainKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public ChapterTask? Task { get; set; }
        public RewardDomain? RewardDomain { get; set; }
        #endregion
    }
}
