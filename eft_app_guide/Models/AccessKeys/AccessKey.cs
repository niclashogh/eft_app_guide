using eft_app_guide.Models.AccessKeys.Config;
using eft_app_guide.Models.Entities;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AccessKeys
{
    [EntityTypeConfiguration(typeof(AccessKeyConfig))]
    public class AccessKey : BasePosition, IPosition
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ItemId { get; set; }
        [Required] public string MapName { get; set; }
        #endregion

        [Required] public bool Show { get; set; }

        #region Relations
        public Item? Item { get; set; }
        public Map? Map { get; set; }

        public List<AccessKeyLoot> AccessKeyLoot { get; set; } = new();
        #endregion
    }
}
