using eft_app_guide.Models.Chapters.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// ChapterTask
    /// x
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
        #endregion
    }
}
