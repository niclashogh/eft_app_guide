using eft_app_guide._Persistence.Entities.Display.Config;
using eft_app_guide.Models.Extractions.Design;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Display.State
{
    /// <summary> AssociationEntity (ExtractionId + MapDisplayId) </summary>
    [EntityTypeConfiguration(typeof(ExtractionDisplayConfig))]
    public class ExtractionDisplay : IPosition
    {
        #region Keys (CompositeKeys)
        [Required] public int ExtractionId { get; set; }
        [Required] public int MapDisplayId { get; set; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations (Parents)
        public Extraction? Extraction { get; set; }
        public MapDisplay? MapDisplay { get; set; }
        #endregion
    }
}
