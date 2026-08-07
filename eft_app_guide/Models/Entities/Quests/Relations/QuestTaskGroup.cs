using eft_app_guide.Models.Graphs;
using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Entities.Quests.Design;
using eft_app_guide.Models.Entities.Quests.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Quests.Relations
{
    /// <summary><b>JunctionTable</b></summary>
    [EntityTypeConfiguration(typeof(QuestTaskGroupConfig))]
    public class QuestTaskGroup : IGroup // TODO
    {
        #region Keys (CompositeKeys)
        [Required] public int QuestTaskId { get; set; }
        [Required] public int GroupId { get; set; }
        #endregion

        #region Relations
        public QuestTask? QuestTask { get; set; }
        public Group? Group { get; set; }
        #endregion
    }
}
