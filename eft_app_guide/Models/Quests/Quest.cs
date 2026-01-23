using eft_app_guide.Models.Characters;
using eft_app_guide.Models.Quests.Config;
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
        [Required] public int TraderId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public QuestLine? QuestLine { get; set; }
        public Trader? Trader { get; set; }

        public List<QuestRequirement> QuestRequirements { get; set; } = [];
        public List<QuestReward> QuestRewards { get; set; } = [];
        public List<QuestTask> QuestTasks { get; set; } = [];
        public List<CharacterQuest> CharacterQuests { get; set; } = [];
        #endregion
    }
}
