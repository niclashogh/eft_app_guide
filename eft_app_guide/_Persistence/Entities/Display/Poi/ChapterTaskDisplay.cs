using eft_app_guide._Persistence.Entities.Display.Config;
using eft_app_guide._Persistence.Entities.Display.Maps;
using eft_app_guide.Models.Chapters.Design;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Display.Poi
{
    /// <summary> AssociationEntity (ChapterTaskId + MapDisplayId) </summary>
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
