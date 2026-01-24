using eft_app_guide.Models._Enums;
using eft_app_guide.Models.Accounts;
using eft_app_guide.Models.Chapters;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Rewards
{
    public class Reward
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        // ...
        [Required] public RewardTypes Type { get; set; }
        [Required] public int TypeKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations
        public List<AccountEditionReward> AccountEditionRewards { get; set; } = [];
        public List<ChapterTaskReward> ChapterTaskRewards { get; set; } = [];
        #endregion
    }
}
