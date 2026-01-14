using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.FleaMarket
{
    public class FleaMarket
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public int UnlockLevel { get; set; }
        [Required] public double Reputation { get; set; }

        #region Relations
        public List<FleaMarketItem> Items { get; set; } = new();
        #endregion
    }
}
