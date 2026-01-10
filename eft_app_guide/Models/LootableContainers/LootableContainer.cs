using eft_app_guide.Models.AccessKeys;
using eft_app_guide.Models.Locations;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.LootableContainers
{
    public class LootableContainer
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int LocationId { get; set; }
        public int? AccessKeyId { get; set; }
        #endregion

        [Required] public bool Locked { get; set; }

        #region Relations
        public Location? Location { get; set; }
        public AccessKey? AccessKey { get; set; }
        #endregion
    }
}
