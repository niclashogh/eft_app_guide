using eft_app_guide.Models.Extractions.Config;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Extractions
{
    /// <summary> Extends Extraction </summary>
    [EntityTypeConfiguration(typeof(ExtractionDisplayConfig))]
    public class ExtractionDisplay : IPosition
    {
        #region Keys
        [Key] public int ExtractionId { get; set; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations (Parents)
        public Extraction? Extraction { get; set; }
        #endregion
    }
}
