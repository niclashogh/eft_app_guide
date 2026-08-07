using eft_app_guide._Objects.Types;
using eft_app_guide.Models._unfinished.Items.Design.Config;
using eft_app_guide.Models._unfinished.MarketPlaces._temp;
using eft_app_guide.Models._unfinished.Recipes.Relations;
using eft_app_guide.Models._unfinished.Traders.Relations;
using eft_app_guide.Models.Entities.Locations.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.Items.Design
{
    [EntityTypeConfiguration(typeof(ItemConfig))]
    public class Item // Outsrc. name etc. to Food, Medical, etc. and only link an item to those ids?
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ItemCategoryId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations
        public ItemCategory? ItemCategory { get; set; }
        public AssociationList<CraftingIngredient> CraftingIngredients { get; set; } = [];
        public AssociationList<CraftingResult> CraftingResults { get; set; } = [];
        public AssociationList<TradePayment> TradePayments { get; set; } = [];
        public AssociationList<TradeResult> TradeResults { get; set; } = [];
        public AssociationList<LocationItem> LocationItems { get; set; } = [];
        public AssociationList<MarketPlaceItem> MarketPlaceItems { get; set; } = [];
        #endregion
    }
}
