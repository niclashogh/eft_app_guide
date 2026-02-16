using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Maps;
using eft_app_guide.Models.Quests.Config;
using eft_app_guide.Models.Quests.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Design
{
    /// <summary> AggregativeEntity (QuestTaskDisplay + QuestTaskGroup + QuestTaskMap) </summary>
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
        #endregion

        #region Relations (Extensions)
        public QuestTaskDisplay? QuestTaskDisplay { get; set; }
        public QuestTaskGroup? QuestTaskGroup { get; set; }
        #endregion
    }
}
