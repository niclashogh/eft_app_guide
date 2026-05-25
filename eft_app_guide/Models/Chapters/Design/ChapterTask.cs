using eft_app_guide._Persistence.Entities.Display;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Chapters.Design.Config;
using eft_app_guide.Models.Chapters.Relations;
using eft_app_guide.Models.Characters.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Design
{
    /// <summary><b>ChildEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Chapter
    /// 
    /// JUNCTIONS:
    /// ChapterTaskGroup
    /// ChapterTaskMap
    /// 
    /// ASSOCIATIONS:
    /// ChapterTaskReward
    /// ChapterTaskDisplay
    /// CharacterChapterTaskProgress
    /// </code></summary>
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

        public AssociationList<ChapterTaskReward> ChapterTaskRewards { get; set; } = [];
        public AssociationList<ChapterTaskDisplay> ChapterTaskDisplays { get; set; } = [];
        public AssociationList<CharacterChapterTaskProgress> CharacterChapterTaskProgressions { get; set; } = [];
        #endregion
    }
}
