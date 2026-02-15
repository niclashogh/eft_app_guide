using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Currency.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Currency
{
    /// <summary> AggregativeEntity (CurrencyConversion) </summary>
    [EntityTypeConfiguration(typeof(CurrencyConfig))]
    public class Currency
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public AssociationList<CurrencyExchange> CurrencyExchanges { get; set; } = [];
        #endregion
    }
}
