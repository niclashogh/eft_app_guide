using eft_app_guide.Models.FleaMarket.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.FleaMarket
{
    /// <summary> AggregativeEntity (FleaMarketItem) </summary>
    [EntityTypeConfiguration(typeof(FleaMarketConfig))]
    public class FleaMarket
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public int PlayerLevel { get; set; }

        #region Relations
        public List<FleaMarketItem> FleaMarketItems { get; set; } = [];
        #endregion
    }
}
