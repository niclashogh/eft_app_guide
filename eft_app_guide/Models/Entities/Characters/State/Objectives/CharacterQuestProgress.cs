using eft_app_guide.Models.Entities.Characters.State.Objectives.Config;
using eft_app_guide.Models.Entities.Quests.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.State.Objectives
{
    /// <summary><b>AssociationEntity</b></summary>
    [EntityTypeConfiguration(typeof(CharacterQuestProgressConfig))]
    public class CharacterQuestProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int QuestId { get; set; }
        #endregion

        [Required] public bool IsActive { get; set; }
        [Required] public bool IsComplete { get; set; }
        [Required] public DateTime CompletionDate { get; set; }

        #region Relations
        public Character? Character { get; set; }
        public Quest? Quest { get; set; }
        #endregion
    }
}
