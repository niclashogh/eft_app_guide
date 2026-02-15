using eft_app_guide.Models.Items;
using eft_app_guide.Models.Traders.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders
{
    /// <summary> AssociationEntity (TraderId + ItemId) </summary>
    [EntityTypeConfiguration(typeof(TraderItemConfig))]
    public class TraderItem // MISSING PAYMENT
    {
        #region Keys
        [Key] public int Id { get; init; } // Remove and make composite key w/ int PaymentGroup
        [Required] public int TraderId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public bool IsLocked { get; set; }

        #region Relations
        public Trader? Trader { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
