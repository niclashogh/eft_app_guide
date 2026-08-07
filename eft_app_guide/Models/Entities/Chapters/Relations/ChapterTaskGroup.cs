using eft_app_guide.Models.Graphs;
using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Entities.Chapters.Design;
using eft_app_guide.Models.Entities.Chapters.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Chapters.Relations
{
    /// <summary><b>JunctionTable</b></summary>
    [EntityTypeConfiguration(typeof(ChapterTaskGroupConfig))]
    public class ChapterTaskGroup : IGroup // TODO ?
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
