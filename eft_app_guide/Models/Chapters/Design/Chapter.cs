using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Chapters.Design.Config;
using eft_app_guide.Models.Characters.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// CHILDREN:
    /// ChapterTask
    /// 
    /// ASSOCIATIONS:
    /// CharacterChapterProgress
    /// </code></summary>
    [EntityTypeConfiguration(typeof(ChapterConfig))]
    public class Chapter
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relatations (Chrildren)
        public List<ChapterTask> ChapterTasks { get; set; } = [];

        public AssociationList<CharacterChapterProgress> CharacterChapterProgressions { get; set; } = [];
        #endregion
    }
}
