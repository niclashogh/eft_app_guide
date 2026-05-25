using eft_app_guide._Persistence.Entities.TargetTypes;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Chapters.Design;
using eft_app_guide.Models.Chapters.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Relations
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// ChapterTaskId
    /// RewardDomainId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(ChapterTaskRewardConfig))]
    public class ChapterTaskReward : IRewardProvider
    {
        #region Keys (CompositeKeys)
        [Required] public int ChapterTaskId { get; set; }
        [Required] public int RewardTargetTypeId { get; set; }
        #endregion

        [Required] public int TargetKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public ChapterTask? Task { get; set; }
        public RewardTargetType? RewardTargetType { get; set; }
        #endregion
    }
}
