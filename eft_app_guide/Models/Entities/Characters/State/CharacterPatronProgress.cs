using eft_app_guide.Models.Entities.Characters.State.Config;
using eft_app_guide.Models.Entities.PatronEntities.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.State
{
    /// <summary><b>AssociationEntity</b></summary>
    [EntityTypeConfiguration(typeof(CharacterPatronProgressConfig))]
    public class CharacterPatronProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int PatronId { get; set; }
        #endregion

        [Required] public bool IsUnlocked { get; set; }

        public double? Reputation { get; set; }
        public int? Level { get; set; }
        public int? TradeValue { get; set; }

        #region Relations
        public Character? Character { get; set; }
        public Patron? Patron { get; set; }
        #endregion
    }
}
