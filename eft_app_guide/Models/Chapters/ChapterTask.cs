using eft_app_guide.Models.Chapters.Config;
using eft_app_guide.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    [EntityTypeConfiguration(typeof(ChapterTaskConfig))]
    public class ChapterTask
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ChapterId { get; set; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public string Description { get; set; }
        [Required] public int Sequence { get; set; }

        #region Relatations
        public Chapter? Chapter { get; set; }
        public Map? Map { get; set; }
        public ChapterTaskDisplay? Display { get; set; }
        #endregion
    }
}
