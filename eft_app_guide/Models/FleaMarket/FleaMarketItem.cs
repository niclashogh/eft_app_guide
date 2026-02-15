using eft_app_guide.Models.FleaMarket.Config;
using eft_app_guide.Models.Items;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.FleaMarket
{
    /// <summary> JunctionEntity (FleaMarketId + ItemId) </summary>
    [EntityTypeConfiguration(typeof(FleaMarketItemConfig))]
    public class FleaMarketItem // TODO - POTENTIONALLY REWORK
    {
        #region Keys (CompositeKeys)
        [Required] public int FleaMarketId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        #region Relations (Parents)
        public FleaMarket? FleaMarket { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
