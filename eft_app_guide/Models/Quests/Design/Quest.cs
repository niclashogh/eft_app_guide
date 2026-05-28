using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Quests.Design.Config;
using eft_app_guide.Models.Quests.Relations;
using eft_app_guide.Models.Traders.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Design
{
    /// <summary><b>ChildEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// QuestLine
    /// Trader
    /// 
    /// CHILDREN:
    /// QuestTask
    /// 
    /// JUNCTIONS:
    /// QuestGroup
    /// 
    /// ASSOCIATIONS:
    /// CharacterQuestProgress
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
        public List<QuestTask> QuestTasks { get; set; } = [];

        public JunctionList<QuestGroup> QuestGroups { get; set; } = [];
        
        public AssociationList<CharacterQuestProgress> CharacterQuestProgressions { get; set; } = [];
        #endregion
    }
}
