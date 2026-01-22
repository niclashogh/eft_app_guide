using eft_app_guide.Models.Characters;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts
{
    public class Account
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int CharacterId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public DateTime WipeDate { get; set; }

        #region Relations
        public Character? Character { get; set; }
        #endregion
    }
}
