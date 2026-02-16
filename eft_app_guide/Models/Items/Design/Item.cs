using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.CraftingRecipes.Design;
using eft_app_guide.Models.Items.Config;
using eft_app_guide.Models.Locations.Design;
using eft_app_guide.Models.MarketPlaces.Design;
using eft_app_guide.Models.Traders.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Items.Design
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
