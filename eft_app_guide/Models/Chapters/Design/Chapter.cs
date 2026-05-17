using eft_app_guide.Models.Chapters.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// CHILDREN:
    /// ChapterTask
    /// </code></summary>
    [EntityTypeConfiguration(typeof(ChapterConfig))]
    public class Chapter // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relatations (Chrildren)
        public List<ChapterTask> ChapterTasks { get; set; } = [];
        // public AssociationList<CharacterChapterProgress> CharacterChapterProgresses { get; set; } = [];
        // public AssociationList<CharacterChapterTaskProgress> CharacterChapterTaskProgresses { get; set; } = [];
        #endregion
    }
}
