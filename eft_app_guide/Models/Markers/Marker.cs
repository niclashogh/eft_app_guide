using eft_app_guide.Models.Maps;
using eft_app_guide.Models.Markers.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Markers
{
    /// <summary> DefinitionEntity </summary>
    [EntityTypeConfiguration(typeof(MarkerConfig))]
    public class Marker
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public string MapId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }

        #region Relations
        public Map? Map { get; set; }
        public MarkerDisplay? MarkerDisplay { get; set; }
        #endregion
    }
}
