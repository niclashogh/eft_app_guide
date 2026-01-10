using eft_app_guide.Models.Items;
using eft_app_guide.Models.Traders.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders
{
    [EntityTypeConfiguration(typeof(TraderItemConfig))]
    public class TraderItem
    {
        #region Keys
        [Key] public int Id { get; init; }
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
