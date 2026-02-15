using eft_app_guide.DataTransferObjects.Enums;
using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Markers.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Markers
{
    /// <summary> Extends Marker </summary>
    [EntityTypeConfiguration(typeof(MarkerDisplayConfig))]
    public class MarkerDisplay : IPosition, ISize
    {
        #region Keys
        [Key] public int MarkerId { get; init; }
        [Required] public int MarkerIconId { get; set; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }
        [Required] public double Width { get; set; }
        [Required] public double Height { get; set; }
        [Required] public OutlineVariants Outline { get; set; }

        #region Relations
        public Marker? Marker { get; set; }
        public MarkerIcon? MarkerIcon { get; set; }
        #endregion
    }
}
