using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Traders.Design.Config;
using eft_app_guide.Models.Traders.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Trader
    /// 
    /// ASSOCIATIONS:
    /// TradePayment
    /// TradeResult
    /// </code></summary>
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
