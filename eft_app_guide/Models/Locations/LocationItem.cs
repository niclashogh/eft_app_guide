using eft_app_guide.Models.Items;
using eft_app_guide.Models.Locations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Locations
{
    /// <summary> AssociationEntity (LocationId + ItemId) </summary>
    [EntityTypeConfiguration(typeof(LocationItemConfig))]
    public class LocationItem
    {
        #region Keys (CompositeKeys)
        [Required] public int LocationId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public int Quantity { get; set; }

        #region Relations
        public Location? Location { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
