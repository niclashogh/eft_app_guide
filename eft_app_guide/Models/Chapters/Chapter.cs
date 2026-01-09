using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    public class Chapter
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
    }
}
