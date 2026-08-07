using eft_app_guide.Models._unfinished.Items.Design;
using eft_app_guide.Models._unfinished.MarketPlaces.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.MarketPlaces._temp
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// MarketPlaceId
    /// ItemId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(MarketPlaceItemConfig))]
    public class MarketPlaceItem // TODO?
    {
        #region Keys (CompositeKeys)
        [Required] public int MarketPlaceId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public bool IsTradeable { get; set; }

        #region Relations (Parents)
        public MarketPlace? MarketPlace { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
