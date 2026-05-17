using eft_app_guide.Models.Chapters.Design;
using eft_app_guide.Models.Chapters.Relations.Config;
using eft_app_guide.Models.Maps.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Relations
{
    /// <summary><b>JunctionEntity</b>
    /// Between:<code>
    /// ChapterTaskId
    /// MapId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(ChapterTaskMapConfig))]
    public class ChapterTaskMap
    {
        #region Keys (CompositeKeys)
        [Required] public int ChapterTaskId { get; set; }
        [Required] public int MapId { get; set; }
        #endregion

        #region Relations (Parents)
        public ChapterTask? ChapterTask { get; set; }
        public Map? Map { get; set; }
        #endregion
    }
}
