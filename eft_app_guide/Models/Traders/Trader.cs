using eft_app_guide.Models.Quests;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders
{
    public class Trader
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public double Reputation { get; set; }

        #region Relations
        public List<TraderLevel> Levels { get; set; } = new();
        public List<Quest> Quests { get; set; } = new();
        #endregion
    }
}
