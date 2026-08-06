using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Characters.State;
using eft_app_guide.Models.Entities.PatronEntities.Design;
using eft_app_guide.Models.Entities.Quests.Design.Config;
using eft_app_guide.Models.Entities.Quests.Relations;
using eft_app_guide.Models.Traders.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Quests.Design
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
    public class Quest // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int QuestLineId { get; set; }
        [Required] public int PatronId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Parents)
        public QuestLine? QuestLine { get; set; }
        public Patron? Patron { get; set; }
        #endregion

        #region Relations (Children)
        public List<QuestTask> QuestTasks { get; set; } = [];

        public JunctionList<QuestGroup> QuestGroups { get; set; } = [];
        
        public AssociationList<CharacterQuestProgress> CharacterQuestProgressions { get; set; } = [];
        #endregion
    }
}
