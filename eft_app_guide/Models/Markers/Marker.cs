using eft_app_guide.Models.Entities;
using eft_app_guide.Models.Enums;
using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Markers.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Markers
{
    [EntityTypeConfiguration(typeof(MarkerConfig))]
    public class Marker : BasePositionAndSize, IPositionAndSize
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public string MapName { get; set; }
        [Required] public int MarkerIconId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }
        [Required] public OutlineVariants Outline { get; set; }

        #region Relations
        public Map? Map { get; set; }
        public MarkerIcon? MarkerIcon { get; set; }
        #endregion
    }
}
