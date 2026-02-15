using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Locations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Locations
{
    /// <summary> Extends Location </summary>
    [EntityTypeConfiguration(typeof(LocationDisplayConfig))]
    public class LocationDisplay : IPosition
    {
        #region Keys
        [Key] public int LocationId { get; set; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations (Parents)
        public Location? Location { get; set; }
        #endregion
    }
}
