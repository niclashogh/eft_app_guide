using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Characters.State;
using eft_app_guide.Models.Entities.Quests.Design;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.PatronEntities.Design
{
    /// <summary><para><b>DefinitionEntity</b> and <b>AggregativeEntity</b></para>
    /// <b>RELATIONS</b><code>
    /// CHILDREN:
    /// Quest
    /// PatronLevel
    /// 
    /// JUNCTIONS:
    /// PatronCurrency
    /// 
    /// ASSOCIATIONS:
    /// CharacterPatronProgress
    /// </code>
    /// 
    /// <b>ABOUT THIS CLASS</b><code>
    /// A Patron is a an entity that can establish a relationship with the player,
    /// providing progression, rewards, reputation, services, and/or trading.
    /// </code></summary>
    public class Patron
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        public string? Description { get; set; }

        #region Relations (Children)
        public List<Quest> Quests { get; set; } = [];
        public List<PatronLevel> PatronLevels { get; set; } = [];

        public JunctionList<PatronCurrency> PatronCurrencies { get; set; } = [];

        public AssociationList<CharacterPatronProgress> CharacterPatronProgressions { get; set; } = [];
        #endregion
    }
}
