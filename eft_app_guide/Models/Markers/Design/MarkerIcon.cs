using eft_app_guide.Models.Markers.Config;
using eft_app_guide.Models.Markers.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Markers.Design
{
    /// <summary> DefinitionEntity </summary>
    [EntityTypeConfiguration(typeof(MarkerIconConfig))]
    public class MarkerIcon
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Icon { get; set; }

        #region Relations
        public List<MarkerDisplay> MarkerDisplays { get; set; } = [];
        #endregion
    }
}
