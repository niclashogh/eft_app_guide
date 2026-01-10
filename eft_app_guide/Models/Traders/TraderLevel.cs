using eft_app_guide.Models.Traders.Enums;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders
{
    public class TraderLevel
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public int TraderId { get; set; }
        #endregion

        [Required] public TraderAccessStates Access { get; set; }
        [Required] public double ReputationRequired { get; set; }

        #region Relations
        public Trader? Trader { get; set; }
        #endregion
    }
}
