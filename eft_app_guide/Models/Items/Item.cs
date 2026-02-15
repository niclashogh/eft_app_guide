using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.FleaMarket;
using eft_app_guide.Models.HideoutStations;
using eft_app_guide.Models.Items.Config;
using eft_app_guide.Models.Locations;
using eft_app_guide.Models.Traders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Items
{
    /// <summary> AggregativeEntity (ItemCategory) </summary>
    [EntityTypeConfiguration(typeof(ItemConfig))]
    public class Item
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ItemCategoryId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations
        public ItemCategory? ItemCategory { get; set; }

        public AssociationList<LocationItem> LocationItems { get; set; } = [];
        public AssociationList<TraderItem> TraderItems { get; set; } = [];
        public AssociationList<FleaMarketItem> FleaMarketItems { get; set; } = [];
        #endregion
    }
}
