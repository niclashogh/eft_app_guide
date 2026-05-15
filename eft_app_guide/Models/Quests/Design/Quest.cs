using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Quests.Config;
using eft_app_guide.Models.Traders.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// QuestLine
    /// Trader
    /// QuestRequirement
    /// QuestReward
    /// QuestTask
    /// CharacterQuestProgress
    /// QuestGroup
    /// </code></summary>
    [EntityTypeConfiguration(typeof(QuestConfig))]
    public class Quest
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int QuestLineId { get; set; }
        [Required] public int TraderId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Parents)
        public QuestLine? QuestLine { get; set; }
        public Trader? Trader { get; set; }
        #endregion

        #region Relations (Children)
        public List<QuestRequirement> QuestRequirements { get; set; } = [];
        public AssociationList<QuestReward> QuestRewards { get; set; } = [];
        public List<QuestTask> QuestTasks { get; set; } = [];
        public AssociationList<CharacterQuestProgress> CharacterQuestProgressions { get; set; } = [];
        #endregion

        #region Relations (Extensions)
        public QuestGroup? QuestGroup { get; set; }
        #endregion
    }
}
