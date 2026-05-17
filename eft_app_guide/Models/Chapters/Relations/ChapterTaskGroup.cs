using eft_app_guide._Persistence.Entities.Grouping;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Chapters.Design;
using eft_app_guide.Models.Chapters.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Relations
{
    /// <summary><b>JunctionTable</b>
    /// Between:<code>
    /// ChapterTaskId
    /// GroupId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(ChapterTaskGroupConfig))]
    public class ChapterTaskGroup : IGroup
    {
        #region Keys (CompositeKeys)
        [Required] public int ChapterTaskId { get; set; }
        [Required] public int GroupId { get; set; }
        #endregion

        #region Relations (Parents)
        public ChapterTask? ChapterTask { get; set; }
        public Group? Group { get; set; }
        #endregion
    }
}
