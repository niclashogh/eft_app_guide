using eft_app_guide.Models.Quests;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities
{
    public class Trader
    {
        [Key] public string Name { get; set; }

        #region Relations
        public List<Quest> Quests { get; set; } = new();
        #endregion
    }
}
