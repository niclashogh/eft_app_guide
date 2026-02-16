using eft_app_guide.Models.Currencies.Design;
using eft_app_guide.Models.Traders.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders.Design
{
    /// <summary> ChildEntity (Trader + Currency) </summary>
    [EntityTypeConfiguration(typeof(TraderLevelConfig))]
    public class TraderLevel
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int TraderId { get; set; }
        [Required] public int CurrencyId { get; set; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public double MinReputation { get; set; }
        [Required] public double MaxReputation { get; set; }
        [Required] public int RequiredTradeVolume { get; set; }

        #region Relations (Parents)
        public Trader? Trader { get; set; }
        public Currency? Currency { get; set; }
        #endregion
    }
}
