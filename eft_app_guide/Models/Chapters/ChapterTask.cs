using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Chapters.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    /// <summary> AggregativeEntity (ChapterTaskGroup + ChapterTaskMap + ChapterTaskReward) </summary>
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
        public JunctionList<ChapterTaskMap> ChapterTaskMaps { get; set; } = [];
        public AssociationList<ChapterTaskReward> ChapterTaskRewards { get; set; } = [];
        #endregion

        #region Relations (Extensions)
        public ChapterTaskDisplay? ChapterTaskDisplay { get; set; }
        public ChapterTaskGroup? ChapterTaskGroup { get; set; }
        #endregion
    }
}
