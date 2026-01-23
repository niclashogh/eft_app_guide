using eft_app_guide.Models.Accounts.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts
{
    [EntityTypeConfiguration(typeof(AccountEditionRewardConfig))]
    public class AccountEditionReward
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int AccountEditionId { get; set; }
        #endregion

        // ...

        #region Relations
        public AccountEdition? Edition { get; set; }
        #endregion
    }
}
