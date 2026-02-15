using eft_app_guide.Models.Characters.Config;
using eft_app_guide.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    /// <summary> AssociationEntity (CharacterId + MapId) </summary>
    [EntityTypeConfiguration(typeof(CharacterMapAccessConfig))]
    public class CharacterMapAccess
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public bool IsLocked { get; set; }

        #region Relations
        public Character? Character { get; set; }
        public Map? Map { get; set; }
        #endregion
    }
}
