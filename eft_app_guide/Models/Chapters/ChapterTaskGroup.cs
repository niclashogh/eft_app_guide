using eft_app_guide.Models.Chapters.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    /// <summary> ChildEntity (ChapterTask) </summary>
    [EntityTypeConfiguration(typeof(ChapterTaskGroupConfig))]
    public class ChapterTaskGroup
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public string GUID { get; set; }
        [Required] public int ChapterTaskId { get; set; }
        #endregion

        #region Relations
        public ChapterTask? ChapterTask { get; set; }
        #endregion
    }
}
