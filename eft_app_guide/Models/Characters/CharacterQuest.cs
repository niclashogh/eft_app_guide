using eft_app_guide.Models.Quests;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class CharacterQuest // JunctionTable to save quest-progressing per character
    {
        #region Keys
        [Key] public int Id { get; init; }
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
