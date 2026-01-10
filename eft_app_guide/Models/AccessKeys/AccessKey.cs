using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AccessKeys
{
    public class AccessKey
    {
        #region Keys
        [Key] public int Id { get; set; }
        #endregion

        [Required] public string Name { get; set; }
    }
}
