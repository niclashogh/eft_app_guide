using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Traders.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders
{
    /// <summary> AggregativeEntity (TradePayment + TradeResult) </summary>
    [EntityTypeConfiguration(typeof(TradeConfig))]
    public class Trade
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int TraderId { get; set; }
        #endregion

        #region Relations (Parents)
        public Trader? Trader { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<TradePayment> TradePayments { get; set; } = [];
        public AssociationList<TradeResult> TradeResults { get; set; } = [];
        #endregion
    }
}
