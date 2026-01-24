using eft_app_guide.Models.Items;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.FleaMarket
{
    public class FleaMarketItem // MISSING
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int FleaMarketId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public int UnlockLevel { get; set; }

        #region Relations
        public FleaMarket? FleaMarket { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
