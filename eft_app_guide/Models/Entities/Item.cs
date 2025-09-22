using eft_app_guide.Models.AccessKeys;
using eft_app_guide.Models.Quests;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities
{
    public class Item
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Category { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations
        public List<AccessKey> AccessKeys { get; set; } = new();
        public List<AccessKeyLoot> AccessKeyLoot { get; set; } = new();
        public List<QuestReward> QuestRewards { get; set; } = new();
        #endregion
    }
}
