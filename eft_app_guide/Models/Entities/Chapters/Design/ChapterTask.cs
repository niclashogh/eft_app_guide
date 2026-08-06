using eft_app_guide._Objects.Types;
using eft_app_guide._Persistence.Entities._temp;
using eft_app_guide.Models.Entities.Chapters.Design.Config;
using eft_app_guide.Models.Entities.Chapters.Relations;
using eft_app_guide.Models.Entities.Characters.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Chapters.Design
{
    [EntityTypeConfiguration(typeof(ChapterTaskConfig))]
    public class ChapterTask
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ChapterId { get; set; }
        #endregion

        [Required] public string Description { get; set; }

        #region Relations (Parents)
        public Chapter? Chapter { get; set; }
        #endregion

        #region Relations (Children)
        public JunctionList<ChapterTaskGroup> ChapterTaskGroups { get; set; } = [];
        public JunctionList<ChapterTaskMap> ChapterTaskMaps { get; set; } = [];

        public AssociationList<ChapterTaskDisplay> ChapterTaskDisplays { get; set; } = [];
        public AssociationList<CharacterChapterTaskProgress> CharacterChapterTaskProgressions { get; set; } = [];
        #endregion
    }
}
