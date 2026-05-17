using eft_app_guide.Models.Maps.Design;
using eft_app_guide.Models.Quests.Design;
using eft_app_guide.Models.Quests.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Relations
{
    /// <summary><b>JunctionEntity</b>
    /// Between:<code>
    /// QuestTaskId
    /// MapId
    /// </code></summary>
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
