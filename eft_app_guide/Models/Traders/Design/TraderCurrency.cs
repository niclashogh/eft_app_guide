using eft_app_guide.Models.Currencies.Design;
using eft_app_guide.Models.Traders.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders.Design
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// TraderId
    /// CurrencyId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(TraderCurrencyConfig))]
    public class TraderCurrency
    {
        #region Keys (CompositeKeys)
        [Required] public int TraderId { get; set; }
        [Required] public int CurrencyId { get; set; }
        #endregion

        [Required] public bool IsPrimary { get; set; }

        #region Relations (Parents)
        public Trader? Trader { get; set; }
        public Currency? Currency { get; set; }
        #endregion
    }
}
