using eft_app_guide.Models.Items.Config;
using eft_app_guide.Models.Items.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Items
{
    [EntityTypeConfiguration(typeof(ItemAccessConfig))]
    public class ItemAccess // ?
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public ItemAccessTypes Type { get; set; }
        [Required] public bool IsActivated { get; set; }

        #region Relations
        public Item? Item { get; set; }
        #endregion
    }
}
