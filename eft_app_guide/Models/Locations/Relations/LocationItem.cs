using eft_app_guide.Models.Items.Design;
using eft_app_guide.Models.Locations.Design;
using eft_app_guide.Models.Locations.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Locations.Relations
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// LocationId
    /// ItemId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(LocationItemConfig))]
    public class LocationItem
    {
        #region Keys (CompositeKeys)
        [Required] public int LocationId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public Location? Location { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
