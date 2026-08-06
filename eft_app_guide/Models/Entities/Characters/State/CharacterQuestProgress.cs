using eft_app_guide.Models.Entities.Characters.State.Config;
using eft_app_guide.Models.Entities.Quests.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.State
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// CharacterId
    /// QuestId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CharacterQuestProgressConfig))]
    public class CharacterQuestProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int QuestId { get; set; }
        #endregion

        [Required] public bool IsActive { get; set; }
        [Required] public bool IsComplete { get; set; }

        #region Relations (Parents)
        public Character? Character { get; set; }
        public Quest? Quest { get; set; }
        #endregion
    }
}
