using eft_app_guide._Persistence.Entities.Display.Config;
using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Quests.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Display
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// QuestTaskId
    /// MapDisplayId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(QuestTaskDisplayConfig))]
    public class QuestTaskDisplay : IPosition
    {
        #region Keys
        [Required] public int QuestTaskId { get; set; }
        [Required] public int MapDisplayId { get; set; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations (Parents)
        public QuestTask? QuestTask { get; set; }
        public MapDisplay? MapDisplay { get; set; }
        #endregion
    }
}
