using eft_app_guide.Models.Items.Design;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.MarketPlaces.Design
{
    public class MarketPlaceItemCategory // TODO
    {
        #region Keys (CompositeKeys)
        [Required] public int MarketPlaceId { get; set; }
        [Required] public int ItemCategoryId { get; set; }
        #endregion

        [Required] public int RequiredCharacterLevel { get; set; }

        #region Relations (Parents)
        public MarketPlace? MarketPlace { get; set; }
        public ItemCategory? ItemCategory { get; set; }
        #endregion
    }
}
