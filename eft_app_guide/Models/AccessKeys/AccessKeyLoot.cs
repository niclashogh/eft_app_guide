using eft_app_guide.Models.AccessKeys.Config;
using eft_app_guide.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AccessKeys
{
    [EntityTypeConfiguration(typeof(AccessKeyLootConfig))]
    public class AccessKeyLoot
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int AccessKeyId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public int Quantity { get; set; }

        #region Relations
        public AccessKey? AccessKey { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}
