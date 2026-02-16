using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Accounts.Config;
using eft_app_guide.Models.Accounts.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts.Design
{
    /// <summary> DefinitionEntity (Standard, Left Behind, Prepare for Escape, Edge of Darkness, The Unheard) </summary>
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
