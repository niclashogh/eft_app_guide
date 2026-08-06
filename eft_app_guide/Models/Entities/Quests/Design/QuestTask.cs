using eft_app_guide._Objects.Types;
using eft_app_guide._Persistence.Entities._temp;
using eft_app_guide.Models.Entities.Quests.Design.Config;
using eft_app_guide.Models.Entities.Quests.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Quests.Design
{
    /// <summary><b>ChildEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Quest
    /// 
    /// JUNCTIONS:
    /// QuestTaskGroup
    /// QuestTaskMap
    /// 
    /// ASSOCIATIONS:
    /// QuestTaskDisplay
    /// </code></summary>
    [EntityTypeConfiguration(typeof(QuestTaskConfig))]
    public class QuestTask
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int QuestId { get; set; }
        #endregion

        [Required] public string Description { get; set; }
        [Required] public int Sequence { get; set; }

        #region Relations (Parents)
        public Quest? Quest { get; set; }
        #endregion

        #region Relations (Children)
        public JunctionList<QuestTaskGroup> QuestTaskGroups { get; set; } = [];
        public JunctionList<QuestTaskMap> QuestTaskMaps { get; set; } = [];

        public AssociationList<QuestTaskDisplay> QuestTaskDisplays { get; set; } = [];
        #endregion
    }
}
