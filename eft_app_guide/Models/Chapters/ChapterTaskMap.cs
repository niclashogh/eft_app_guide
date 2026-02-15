using eft_app_guide.Models.Chapters.Config;
using eft_app_guide.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    /// <summary> JunctionEntity (ChapterTaskId + MapId) </summary>
    [EntityTypeConfiguration(typeof(ChapterTaskMapConfig))]
    public class ChapterTaskMap
    {
        #region Keys (CompositeKeys)
        [Required] public int ChapterTaskId { get; set; }
        [Required] public int MapId { get; set; }
        #endregion

        #region Relations
        public ChapterTask? ChapterTask { get; set; }
        public Map? Map { get; set; }
        #endregion
    }
}
