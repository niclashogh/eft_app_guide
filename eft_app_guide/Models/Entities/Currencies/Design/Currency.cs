using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Currencies.Design.Config;
using eft_app_guide.Models.Entities.Currencies.Relations;
using eft_app_guide.Models.Entities.PatronEntities.Design;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Currencies.Design
{
    [EntityTypeConfiguration(typeof(CurrencyConfig))]
    public class Currency : IGraphTarget
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public AssociationList<CurrencyExchange> CurrencyExchanges { get; set; } = [];
        public AssociationList<PatronCurrency> PatronCurrencies { get; set; } = [];
        #endregion
    }
}
