using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Rewards;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    public class ChapterTaskReward : IRewardProvider // JunctionTable, AssociationEntity
    {

        #region Keys (CompositeKeys)
        [Required] public int ChapterTaskId { get; set; }
        [Required] public int RewardId { get; set; }
        #endregion

        [Required] public string Description { get; set; }

        #region Relations
        public ChapterTask? Task { get; set; }
        public Reward? Reward { get; set; }
        #endregion
    }
}
