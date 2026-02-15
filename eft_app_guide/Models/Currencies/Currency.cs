using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Currencies.Config;
using eft_app_guide.Models.Traders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Currencies
{
    /// <summary> AggregativeEntity (CurrencyExchange) </summary>
    [EntityTypeConfiguration(typeof(CurrencyConfig))]
    public class Currency
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public AssociationList<CurrencyExchange> CurrencyExchanges { get; set; } = [];
        public List<TraderLevel> TraderLevels { get; set; } = [];
        #endregion
    }
}
