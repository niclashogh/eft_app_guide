using eft_app_guide.Models.Entities;
using eft_app_guide.Models.Quests.Config;
using eft_app_guide.Models.Quests.Enums;
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
        [Required] public string TraderName { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public QuestAccess Access { get; set; }
        [Required] public bool IsActive { get; set; }
        [Required] public bool IsComplete { get; set; }

        #region Relations
        public QuestLine? QuestLine { get; set; }
        public Trader? Trader { get; set; }

        public List<QuestRequirement> QuestRequirements { get; set; } = new();
        public List<QuestReward> QuestRewards { get; set; } = new();
        public List<QuestTask> QuestTasks { get; set; } = new();
        #endregion
    }
}
