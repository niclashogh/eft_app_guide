using eft_app_guide._Persistence._Interface;
using eft_app_guide._Persistence.Entities.Display.Config;
using eft_app_guide.Models.Chapters.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Display
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// ChapterTaskId
    /// MapDisplayId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(ChapterTaskDisplayConfig))]
    public class ChapterTaskDisplay : IPosition
    {
        #region Keys (CompositeKeys)
        [Required] public int ChapterTaskId { get; set; }
        [Required] public int MapDisplayId { get; set; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations (Parents)
        public ChapterTask? ChapterTask { get; set; }
        public MapDisplay? MapDisplay { get; set; }
        #endregion
    }
}
