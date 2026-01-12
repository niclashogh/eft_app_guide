using eft_app_guide.Models.Chapters.Config;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    [EntityTypeConfiguration(typeof(ChapterTaskDisplayConfig))]
    public class ChapterTaskDisplay : IPosition
    {
        #region Keys
        [Key] public int ChapterTaskId { get; set; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations
        public ChapterTask? ChapterTask { get; set; }
        #endregion
    }
}
