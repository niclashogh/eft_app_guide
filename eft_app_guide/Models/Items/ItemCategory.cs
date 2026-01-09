using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Items
{
    public class ItemCategory
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<Item> Items { get; set; } = new();
        #endregion
    }
}
