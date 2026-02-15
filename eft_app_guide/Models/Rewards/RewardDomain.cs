using eft_app_guide._Persistence.Enums;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Accounts;
using eft_app_guide.Models.Chapters;
using eft_app_guide.Models.Rewards.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Rewards
{
    /// <summary> DefintionEntity </summary>
    [EntityTypeConfiguration(typeof(RewardDomainConfig))]
    public class RewardDomain
    {
        #region Keys
        [Key] public RewardDomains Id { get; init; }
        #endregion

        [Required] public string Description { get; set; }

        #region Relations (Children)
        public AssociationList<AccountEditionReward> AccountEditionRewards { get; set; } = [];
        public AssociationList<ChapterTaskReward> ChapterTaskRewards { get; set; } = [];
        #endregion
    }
}
