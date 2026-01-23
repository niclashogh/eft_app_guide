using eft_app_guide.Models.Accounts.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts
{
    [EntityTypeConfiguration(typeof(AccountEditionConfig))]
    public class AccountEdition // Standard, LeftBehind, PrepareForEscape, EdgeOfDarkness & TheUnheard
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<Account> Accounts { get; set; } = [];
        public List<AccountEditionReward> Rewards { get; set; } = [];
        #endregion
    }
}
