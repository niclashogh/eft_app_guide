using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Chapters.Design.Config;
using eft_app_guide.Models.Entities.Chapters.Relations;
using eft_app_guide.Models.Entities.Characters.State.Objectives;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Chapters.Design
{
    [EntityTypeConfiguration(typeof(ChapterTaskConfig))]
    public class ChapterTask : IGraphTarget, IGraphSource
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ChapterId { get; set; }
        #endregion

        [Required] public string Description { get; set; }

        #region Relations
        public Chapter? Chapter { get; set; }
        public JunctionList<ChapterTaskGroup> ChapterTaskGroups { get; set; } = [];
        public JunctionList<ChapterTaskMap> ChapterTaskMaps { get; set; } = [];
        public AssociationList<CharacterChapterTaskProgress> CharacterChapterTaskProgressions { get; set; } = [];
        #endregion
    }
}
