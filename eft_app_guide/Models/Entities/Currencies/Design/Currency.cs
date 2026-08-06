using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Currencies.Design.Config;
using eft_app_guide.Models.Entities.Currencies.Relations;
using eft_app_guide.Models.Entities.Traders.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Currencies.Design
{
    /// <summary><b>DefinitionEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// ASSOCIATIONS:
    /// CurrencyExchange
    /// TraderCurrency
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CurrencyConfig))]
    public class Currency
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public AssociationList<CurrencyExchange> CurrencyExchanges { get; set; } = [];
        public AssociationList<TraderCurrency> TraderCurrencies { get; set; } = [];
        #endregion
    }
}
