using eft_app_guide.Models.Traders.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders.Design
{
    /// <summary><b>ChildEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Trader
    /// 
    /// CHILDREN:
    /// Trade
    /// 
    /// </code></summary>
    [EntityTypeConfiguration(typeof(TraderLevelConfig))]
    public class TraderLevel
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

        #region Relations (Children)
        public List<Trade> Trades { get; set; } = [];
        #endregion
    }
}
