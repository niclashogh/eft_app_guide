using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Design
{
    /// <summary><b>Extends QuestTask</b></summary>
    [EntityTypeConfiguration(typeof(QuestTaskGroupConfig))]
    public class QuestTaskGroup : IGroup
    {
        #region Keys
        [Key] public int QuestTaskId { get; set; }
        [Required] public string GUID { get; set; }
        #endregion

        #region Relations (Parents)
        public QuestTask? QuestTask { get; set; }
        #endregion
    }
}
