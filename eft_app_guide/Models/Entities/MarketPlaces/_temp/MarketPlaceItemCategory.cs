using eft_app_guide.Models.Entities.Items.Design;
using eft_app_guide.Models.Entities.MarketPlaces.Design;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.MarketPlaces._temp
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
