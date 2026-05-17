using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Accounts.Design.Config;
using eft_app_guide.Models.Accounts.Relations;
using eft_app_guide.Models.Accounts.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts.Design
{
    /// <summary><b>DefinitionEntity</b>
    /// Containing:<code>
    /// EOD
    /// The Unheard
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(AccountEditionConfig))]
    public class AccountEdition
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public List<Account> Accounts { get; set; } = [];

        public AssociationList<AccountEditionReward> AccountEditionRewards { get; set; } = [];
        #endregion
    }
}
