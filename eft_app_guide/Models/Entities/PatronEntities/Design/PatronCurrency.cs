using eft_app_guide.Models.Entities.Currencies.Design;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.PatronEntities.Design
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// PatronId
    /// CurrencyId
    /// </code></summary>
    public class PatronCurrency
    {
        #region Keys (CompositeKeys)
        [Required] public int PatronId { get; set; }
        [Required] public int CurrencyId { get; set; }
        #endregion

        [Required] public bool IsPrimary { get; set; }

        #region Relations (Parents)
        public Patron? Patron { get; set; }
        public Currency? Currency { get; set; }
        #endregion
    }
}
