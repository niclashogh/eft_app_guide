using eft_app_guide.Models.Items;
using eft_app_guide.Models.Items.Enums;
using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests
{
    [EntityTypeConfiguration(typeof(QuestRewardConfig))]
    public class QuestReward // ?
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int QuestId { get; set; }
        public int? ItemId { get; set; }
        #endregion

        public int? Quantity { get; set; }
        public ItemAccessTypes? RewardType { get; set; }

        #region Relations
        public Quest? Quest { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
