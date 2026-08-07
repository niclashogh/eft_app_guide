using eft_app_guide.Models.Entities.Quests.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Quests.Design
{
    [EntityTypeConfiguration(typeof(QuestLineConfig))]
    public class QuestLine
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<Quest> Quests { get; set; } = [];
        #endregion
    }
}
