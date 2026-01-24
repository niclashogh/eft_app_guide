using eft_app_guide.Models.Quests;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class CharacterQuestProgress // JunctionTable, AssociationEntity
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int QuestId { get; set; }
        #endregion

        [Required] public bool IsActive { get; set; }
        [Required] public bool IsComplete { get; set; }

        #region Relations
        public Character? Character { get; set; }
        public Quest? Quest { get; set; }
        #endregion
    }
}
