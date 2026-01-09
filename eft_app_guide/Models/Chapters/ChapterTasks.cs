using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    public class ChapterTasks
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ChapterId { get; set; }
        [Required] public int MapName { get; set; }
        #endregion

        [Required] public string Description { get; set; }
        [Required] public int Sequence { get; set; }
    }
}
