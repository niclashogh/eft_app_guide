using eft_app_guide.Models._Enums;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests
{
    [EntityTypeConfiguration(typeof(QuestRewardConfig))]
    public class QuestReward : IReward
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int QuestId { get; set; }
        #endregion

        [Required] public string Description { get; set; }
        [Required] public RewardTypes Type { get; set; }
        [Required] public int TypeKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations
        public Quest? Quest { get; set; }
        #endregion
    }
}
