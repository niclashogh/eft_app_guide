using eft_app_guide.Models.Quests;
using eft_app_guide.Models.Traders.Enums;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders
{
    public class Trader
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public TraderAccess Access { get; set; }
        [Required] public double Reputation { get; set; }
        [Required] public int Level { get; set; }

        #region Relations
        public List<Quest> Quests { get; set; } = new();
        #endregion
    }
}
