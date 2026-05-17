using eft_app_guide.Models.Traders.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders.Design
{
    /// <summary><b>ChildEntity of Trader</b></summary>
    [EntityTypeConfiguration(typeof(TraderLevelConfig))]
    public class TraderLevel // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int TraderId { get; set; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public double MinReputation { get; set; }
        [Required] public double MaxReputation { get; set; }
        [Required] public int RequiredTradeValue { get; set; }

        #region Relations (Parents)
        public Trader? Trader { get; set; }
        #endregion
    }
}
