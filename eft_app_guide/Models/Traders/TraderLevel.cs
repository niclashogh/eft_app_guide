using eft_app_guide.Models.Traders.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders
{
    [EntityTypeConfiguration(typeof(TraderLevelConfig))]
    public class TraderLevel // Add TraderLevelReward ?
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int TraderId { get; set; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public bool IsLocked { get; set; }
        [Required] public double MinReputation { get; set; }
        [Required] public double MaxReputation { get; set; }

        #region Relations
        public Trader? Trader { get; set; }
        #endregion
    }
}
