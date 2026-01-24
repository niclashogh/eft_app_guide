using eft_app_guide.Models.Maps;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    public class ChapterTaskMap // JunctionTable
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
