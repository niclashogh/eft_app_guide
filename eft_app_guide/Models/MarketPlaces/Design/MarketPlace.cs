using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.MarketPlaces._temp;
using eft_app_guide.Models.MarketPlaces.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.MarketPlaces.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// ASSOCIATIONS:
    /// MarketPlaceItem
    /// </code></summary>
    [EntityTypeConfiguration(typeof(MarketPlaceConfig))]
    public class MarketPlace
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public AssociationList<MarketPlaceItem> MarketPlaceItems { get; set; } = [];
        #endregion
    }
}
