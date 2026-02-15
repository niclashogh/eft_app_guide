using eft_app_guide.Models.Maps;
using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests
{
    /// <summary> JunctionEntity (QuestTaskId + MapId) </summary>
    [EntityTypeConfiguration(typeof(QuestTaskMapConfig))]
    public class QuestTaskMap
    {
        #region Keys (CompositeKeys)
        [Required] public int QuestTaskId { get; set; }
        [Required] public int MapId { get; set; }
        #endregion

        #region Relations (Parents)
        public QuestTask? QuestTask { get; set; }
        public Map? Map { get; set; }
        #endregion
    }
}
