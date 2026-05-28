using eft_app_guide._Objects.Types;
using eft_app_guide.Models.CraftingRecipes.Relations;
using eft_app_guide.Models.Items.Design.Config;
using eft_app_guide.Models.Locations.Relations;
using eft_app_guide.Models.MarketPlaces._temp;
using eft_app_guide.Models.Traders.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Items.Design
{
    /// <summary><b>ChildEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// ItemCategory
    /// 
    /// ASSOCIATIONS:
    /// CraftingIngredient
    /// CraftingResult
    /// TradePayment
    /// TradeResult
    /// LocationItem
    /// MarketPlaceItem
    /// </code></summary>
    [EntityTypeConfiguration(typeof(ItemConfig))]
    public class Item
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ItemCategoryId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations (Parents)
        public ItemCategory? ItemCategory { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<CraftingIngredient> CraftingIngredients { get; set; } = [];
        public AssociationList<CraftingResult> CraftingResults { get; set; } = [];
        public AssociationList<TradePayment> TradePayments { get; set; } = [];
        public AssociationList<TradeResult> TradeResults { get; set; } = [];
        public AssociationList<LocationItem> LocationItems { get; set; } = [];
        public AssociationList<MarketPlaceItem> MarketPlaceItems { get; set; } = [];
        #endregion
    }
}
