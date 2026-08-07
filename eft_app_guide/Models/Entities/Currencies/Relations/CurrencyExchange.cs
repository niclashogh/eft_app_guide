using eft_app_guide.Models.Entities.Currencies.Design;
using eft_app_guide.Models.Entities.Currencies.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Currencies.Relations
{
    /// <summary><b>AssociationEntity</b></summary>
    [EntityTypeConfiguration(typeof(CurrencyExchangeConfig))]
    public class CurrencyExchange
    {
        #region Keys (CompositeKeys)
        [Required] public int FromCurrencyId { get; set; }
        [Required] public int ToCurrencyId { get; set; }
        #endregion

        /// <summary> How many "ToCurrency", "FromCurrency" can buy </summary>
        [Required] public int Rate { get; set; }

        #region Relations
        public Currency? FromCurrency { get; set; }
        public Currency? ToCurrency { get; set; }
        #endregion
    }
}
