using eft_app_guide.Models.Entities.Accounts.Design.Config;
using eft_app_guide.Models.Entities.Accounts.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Accounts.Design
{
    /// <summary><b>DefintionEntity</b></summary>
    [EntityTypeConfiguration(typeof(AccountEditionConfig))]
    public class AccountEdition
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public List<Account> Accounts { get; set; } = [];
        #endregion
    }
}
