using eft_app_guide.Models.Items;
using eft_app_guide.Models.Traders.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders
{
    /// <summary> AssociationEntity (TradeId + ItemId) </summary>
    [EntityTypeConfiguration(typeof(TradePaymentConfig))]
    public class TradePayment
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
