using eft_app_guide.Models.Characters.State.Config;
using eft_app_guide.Models.Traders.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.State
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// CharacterId
    /// TraderId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CharacterTraderReputationConfig))]
    public class CharacterTraderReputation
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int TraderId { get; set; }
        #endregion

        [Required] public bool HasAchieved { get; set; }
        [Required] public double Reputation { get; set; }

        #region Relations (Parents)
        public Character? Character { get; set; }
        public Trader? Trader { get; set; }
        #endregion
    }
}
