using eft_app_guide.Models.Entities.Characters.Design;
using eft_app_guide.Models.Entities.Factions.Design;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Display
{
    /// <summary><b>AssociationEntity</b></summary>
    public class FactionCharacterLevelDisplay // TODO
    {
        #region Keys
        [Required] public int FactionId { get; set; }
        [Required] public int CharacterLevelId { get; set; }
        #endregion

        [Required] public string Badge { get; set; }

        #region Relations
        public Faction? Faction { get; set; }
        public CharacterLevel? CharacterLevel { get; set; }
        #endregion
    }
}
