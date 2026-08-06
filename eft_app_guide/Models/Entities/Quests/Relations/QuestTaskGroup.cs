using eft_app_guide.Models._Graph;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Entities.Quests.Design;
using eft_app_guide.Models.Entities.Quests.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Quests.Relations
{
    /// <summary><b>JunctionTable</b>
    /// Between:<code>
    /// QuestTaskId
    /// GroupId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(QuestTaskGroupConfig))]
    public class QuestTaskGroup : IGroup
    {
        #region Keys (CompositeKeys)
        [Required] public int QuestTaskId { get; set; }
        [Required] public int GroupId { get; set; }
        #endregion

        #region Relations (Parents)
        public QuestTask? QuestTask { get; set; }
        public Group? Group { get; set; }
        #endregion
    }
}
