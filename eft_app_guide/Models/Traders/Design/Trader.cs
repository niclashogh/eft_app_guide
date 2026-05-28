using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Quests.Design;
using eft_app_guide.Models.Traders.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders.Design
{
    /// <summary><b>DefinitionEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// CHILDREN:
    /// Quest
    /// TraderLevel
    /// 
    /// JUNCTIONS:
    /// TraderCurrency
    /// 
    /// ASSOCIATIONS:
    /// CharacterTraderProgress
    /// </code></summary>
    [EntityTypeConfiguration(typeof(TraderConfig))]
    public class Trader
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        public string? Description { get; set; }

        #region Relations (Children)
        public List<Quest> Quests { get; set; } = [];
        public List<TraderLevel> TraderLevels { get; set; } = [];

        public JunctionList<TraderCurrency> TraderCurrencies { get; set; } = [];

        public AssociationList<CharacterTraderProgress> CharacterTraderProgressions { get; set; } = [];
        #endregion
    }
}
