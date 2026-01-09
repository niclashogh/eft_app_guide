using eft_app_guide.Models.Quests.Enums;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    public class ChapterReward
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ChapterId { get; set; }
        public int? ItemId { get; set; } // ?
        #endregion

        public int? Quantity { get; set; } // ?
        public QuestRewardTypes? RewardType { get; set; } // ?
    }
}
