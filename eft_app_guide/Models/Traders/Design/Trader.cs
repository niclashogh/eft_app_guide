using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Quests.Design;
using eft_app_guide.Models.Traders.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// CHILDREN:
    /// Quest
    /// TraderLevel
    /// Trade
    /// 
    /// JUNCTIONS:
    /// TraderCurrency
    /// 
    /// ASSOCIATIONS:
    /// CharacterTraderProgress
    /// </code></summary>
    [EntityTypeConfiguration(typeof(TraderConfig))]
    public class Trader // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        public string? Description { get; set; }
        public string? Found {  get; set; }

        #region Relations (Children)
        public List<Quest> Quests { get; set; } = [];
        public List<TraderLevel> TraderLevels { get; set; } = [];
        public List<Trade> Trades { get; set; } = [];

        public JunctionList<TraderCurrency> TraderCurrencies { get; set; } = [];

        public AssociationList<CharacterTraderProgress> CharacterTraderProgressions { get; set; } = [];
        #endregion
    }
}
