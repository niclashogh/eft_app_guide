using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Quests.Design;
using eft_app_guide.Models.Traders.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders.Design
{
    /// <summary> AggregativeEntity (TraderLevel + Trade) </summary>
    [EntityTypeConfiguration(typeof(TraderConfig))]
    public class Trader
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public List<Quest> Quests { get; set; } = [];
        public List<TraderLevel> TraderLevels { get; set; } = [];
        public List<Trade> Trades { get; set; } = [];

        public AssociationList<CharacterTraderReputation> CharacterTraderReputations { get; set; } = [];
        #endregion
    }
}
