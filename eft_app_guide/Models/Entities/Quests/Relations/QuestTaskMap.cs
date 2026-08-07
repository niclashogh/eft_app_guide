using eft_app_guide.Models.Entities.Maps.Design;
using eft_app_guide.Models.Entities.Quests.Design;
using eft_app_guide.Models.Entities.Quests.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Quests.Relations
{
    /// <summary><b>JunctionEntity</b></summary>
    [EntityTypeConfiguration(typeof(QuestTaskMapConfig))]
    public class QuestTaskMap
    {
        #region Keys (CompositeKeys)
        [Required] public int QuestTaskId { get; set; }
        [Required] public int MapId { get; set; }
        #endregion

        #region Relations
        public QuestTask? QuestTask { get; set; }
        public Map? Map { get; set; }
        #endregion
    }
}
