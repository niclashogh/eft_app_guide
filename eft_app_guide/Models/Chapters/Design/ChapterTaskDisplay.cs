using eft_app_guide.Models.Chapters.Config;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Design
{
    /// <summary> Extends ChapterTask </summary>
    [EntityTypeConfiguration(typeof(ChapterTaskDisplayConfig))]
    public class ChapterTaskDisplay : IPosition
    {
        #region Keys
        [Key] public int ChapterTaskId { get; init; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations (Parents)
        public ChapterTask? ChapterTask { get; set; }
        #endregion
    }
}
