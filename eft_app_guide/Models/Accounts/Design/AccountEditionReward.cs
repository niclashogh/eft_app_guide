using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Accounts.Config;
using eft_app_guide.Models.Rewards.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts.Design
{
    /// <summary> AssociationEntity (AccountEditionId + RewardDomainId) </summary>
    [EntityTypeConfiguration(typeof(AccountEditionRewardConfig))]
    public class AccountEditionReward : IRewardProvider
    {
        #region Keys (CompositeKeys)
        [Required] public int AccountEditionId { get; set; }
        [Required] public int RewardDomainId { get; set; }
        #endregion

        [Required] public int DomainKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public AccountEdition? AccountEdition { get; set; }
        public RewardDomain? RewardDomain { get; set; }
        #endregion
    }
}
