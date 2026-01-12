using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests
{
    [EntityTypeConfiguration(typeof(QuestTaskDisplayConfig))]
    public class QuestTaskDisplay : IPosition
    {
        #region Keys
        [Key] public int QuestTaskId { get; set; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations
        public QuestTask? QuestTask { get; set; }
        #endregion
    }
}
