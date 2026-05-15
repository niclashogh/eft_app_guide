using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Chapters.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters.Design
{
    /// <summary><b>Extends ChapterTask</b></summary>
    [EntityTypeConfiguration(typeof(ChapterTaskGroupConfig))]
    public class ChapterTaskGroup : IGroup
    {
        #region Keys
        [Key] public int ChapterTaskId { get; set; }
        [Required] public string GUID { get; set; }
        #endregion

        #region Relations (Parents)
        public ChapterTask? ChapterTask { get; set; }
        #endregion
    }
}
