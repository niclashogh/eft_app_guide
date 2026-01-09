using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    public class ChapterRequirement
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ChapterId { get; set; }
        #endregion

        [Required] public string Requirement { get; set; }
    }
}
