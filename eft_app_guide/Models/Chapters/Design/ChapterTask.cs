using eft_app_guide._Persistence.Entities.Display;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Chapters.Design.Config;
using eft_app_guide.Models.Chapters.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Design
{
    /// <summary><b>AggregativeEntity</b>
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
        #endregion
    }
}
