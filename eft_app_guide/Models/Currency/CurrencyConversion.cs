using eft_app_guide.Models.Currency.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Currency
{
    [EntityTypeConfiguration(typeof(CurrencyConversionConfig))]
    public class CurrencyConversion
    {
        #region Keys (CompositeKeys)
        [Required] public int FromCurrencyId { get; set; }
        [Required] public int ToCurrencyId { get; set; }
        #endregion

        /// <summary> 1 FromCurrecy = x ToCurrency </summary>
        [Required] public int Rate { get; set; }

        #region Relations
        public Currency? FromCurrency { get; set; }
        public Currency? ToCurrency { get; set; }
        #endregion
    }
}
