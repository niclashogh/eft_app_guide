using eft_app_guide.Models.Items.Enums;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Items
{
    public class ItemAccess
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public ItemAccessTypes Type { get; set; }
        [Required] public bool Unlocked { get; set; }

        #region Relations
        public Item? Item { get; set; }
        #endregion
    }
}
