using eft_app_guide._Persistence.Entities.Display.State;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Design
{
    /// <summary> AggregativeEntity (QuestTaskGroup + QuestTaskMap + QuestTaskDisplay) </summary>
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
        public JunctionList<QuestTaskMap> QuestTaskMaps { get; set; } = [];
        public AssociationList<QuestTaskDisplay> QuestTaskDisplays { get; set; } = [];
        #endregion

        #region Relations (Extensions)
        public QuestTaskGroup? QuestTaskGroup { get; set; }
        #endregion
    }
}
