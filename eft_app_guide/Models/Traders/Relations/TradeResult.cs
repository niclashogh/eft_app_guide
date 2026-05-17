using eft_app_guide.Models.Items.Design;
using eft_app_guide.Models.Traders.Design;
using eft_app_guide.Models.Traders.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders.Relations
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// TradeId
    /// ItemId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(TradeResultConfig))]
    public class TradeResult
    {
        #region Keys (CompositeKeys)
        [Required] public int TradeId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public Trade? Trade { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
