using eft_app_guide.Models.Entities.Characters.State.Config;
using eft_app_guide.Models.Entities.Maps.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.State
{
    /// <summary><b>AssociationEntity</b></summary>
    [EntityTypeConfiguration(typeof(CharacterMapAccessConfig))]
    public class CharacterMapAccess
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public bool IsUnlocked { get; set; }

        #region Relations
        public Character? Character { get; set; }
        public Map? Map { get; set; }
        #endregion
    }
}
