using eft_app_guide.Models.Currency.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Currency
{
    [EntityTypeConfiguration(typeof(CurrencyConfig))]
    public class Currency
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<CurrencyConversion> Conversions { get; set; } = [];
        #endregion
    }
}
