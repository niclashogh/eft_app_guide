using eft_app_guide.Models.Items;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.FleaMarket
{
    public class FleaMarketItem
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public int RequiredLevel { get; set; }

        #region Relations
        public Item? Item { get; set; }
        #endregion
    }
}
