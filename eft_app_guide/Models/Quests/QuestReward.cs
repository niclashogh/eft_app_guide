using eft_app_guide.Models.Entities;
using eft_app_guide.Models.Quests.Config;
using eft_app_guide.Models.Quests.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests
{
    [EntityTypeConfiguration(typeof(QuestRewardConfig))]
    public class QuestReward
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public int QuestId { get; set; }
        public int? ItemId { get; set; }
        #endregion

        [Required] public QuestRewardTypes RewardType { get; set; }

        #region Relations
        public Quest? Quest { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
