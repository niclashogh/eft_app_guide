using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Characters.State;
using eft_app_guide.Models.Entities.Quests.Design;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.PatronEntities.Design
{
    public class Patron // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        public string? Description { get; set; }

        #region Relations
        public List<Quest> Quests { get; set; } = [];
        public List<PatronLevel> PatronLevels { get; set; } = [];
        public JunctionList<PatronCurrency> PatronCurrencies { get; set; } = [];
        public AssociationList<CharacterPatronProgress> CharacterPatronProgressions { get; set; } = [];
        #endregion
    }
}
