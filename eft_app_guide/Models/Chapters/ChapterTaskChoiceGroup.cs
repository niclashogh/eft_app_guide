using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    public class ChapterTaskChoiceGroup // MISSING, REDO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int OriginalChapterTaskId { get; set; }
        [Required] public int AlternativeChapterTaskId { get; set; }
        #endregion

        [Required] public bool AltersStoryLine { get; set; }

        #region Relations
        public ChapterTask? OriginalChapterTask { get; set; }
        public ChapterTask? AlternativeChapterTask { get; set; }
        #endregion
    }
}
