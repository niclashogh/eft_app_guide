using eft_app_guide._Persistence.Entities.TargetTypes;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Accounts.Design;
using eft_app_guide.Models.Accounts.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts.Relations
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// AccountEditionId
    /// RewardDomainId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(AccountEditionRewardConfig))]
    public class AccountEditionReward : IRewardProvider
    {
        #region Keys (CompositeKeys)
        [Required] public int AccountEditionId { get; set; }
        [Required] public int RewardTargetTypeId { get; set; }
        #endregion

        [Required] public int TargetKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public AccountEdition? AccountEdition { get; set; }
        public RewardTargetType? RewardTargetType { get; set; }
        #endregion
    }
}
