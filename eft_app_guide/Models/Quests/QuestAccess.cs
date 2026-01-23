using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests
{
    public class QuestAccess // Initial, Locked, Unlocked
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Type { get; set; }

        #region Relations
        public List<Quest> Quests { get; set; } = [];
        #endregion
    }
}
