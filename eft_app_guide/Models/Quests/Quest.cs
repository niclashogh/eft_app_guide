using eft_app_guide.Models.Quests.Config;
using eft_app_guide.Models.Quests.Enums;
using eft_app_guide.Models.Traders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests
{
    [EntityTypeConfiguration(typeof(QuestConfig))]
    public class Quest
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int QuestLineId { get; set; }
        [Required] public string TraderId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public QuestAccess Access { get; set; }
        [Required] public bool IsActive { get; set; }
        [Required] public bool IsComplete { get; set; }

        #region Relations
        public QuestLine? QuestLine { get; set; }
        public Trader? Trader { get; set; }

        public List<QuestRequirement> Requirements { get; set; } = new();
        public List<QuestReward> Rewards { get; set; } = new();
        public List<QuestTask> Tasks { get; set; } = new();
        #endregion
    }
}
