using eft_app_guide.Models.AccessKeys;
using eft_app_guide.Models.Quests;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Items
{
    public class Item
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int CategoryId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations
        public ItemCategory? Category { get; set; }
        public List<AccessKey> AccessKeys { get; set; } = new();
        public List<AccessKeyLoot> AccessKeyLoot { get; set; } = new();
        public List<QuestReward> QuestRewards { get; set; } = new();
        #endregion
    }
}
