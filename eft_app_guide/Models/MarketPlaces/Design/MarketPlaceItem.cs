using eft_app_guide.Models.Items.Design;
using eft_app_guide.Models.MarketPlaces.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.MarketPlaces.Design
{
    /// <summary> AssociationEntity (MarketPlaceId + ItemId) </summary>
    [EntityTypeConfiguration(typeof(MarketPlaceItemConfig))]
    public class MarketPlaceItem
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
