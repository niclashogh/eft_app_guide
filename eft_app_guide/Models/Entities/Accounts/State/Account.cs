using eft_app_guide.Models.Entities.Accounts.Design;
using eft_app_guide.Models.Entities.Accounts.State.Config;
using eft_app_guide.Models.Entities.Characters.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Accounts.State
{
    [EntityTypeConfiguration(typeof(AccountConfig))]
    public class Account
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int AccountEditionId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public DateTime WipeDate { get; set; }

        #region Relations (Parents)
        public AccountEdition? AccountEdition { get; set; }
        #endregion

        #region Relations (Children)
        public List<Character> Characters { get; set; } = [];
        #endregion
    }
}
