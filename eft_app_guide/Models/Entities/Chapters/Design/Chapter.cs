using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Chapters.Design.Config;
using eft_app_guide.Models.Entities.Characters.State.Objectives;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Chapters.Design
{
    /// <summary><b>DefintionEntity</b></summary>
    [EntityTypeConfiguration(typeof(ChapterConfig))]
    public class Chapter : IGraphTarget, IGraphSource
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relatations
        public List<ChapterTask> ChapterTasks { get; set; } = [];
        public AssociationList<CharacterChapterProgress> CharacterChapterProgressions { get; set; } = [];
        #endregion
    }
}
