using eft_app_guide.Models.HideoutStations.Config;
using eft_app_guide.Models.Items;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    [EntityTypeConfiguration(typeof(StationItemConfig))]
    public class StationItem
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public int StationId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public bool IsLocked { get; set; }

        #region Relations
        public Station? Station { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
