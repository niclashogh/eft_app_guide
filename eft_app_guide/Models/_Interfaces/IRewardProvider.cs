using eft_app_guide.Models.Rewards;

namespace eft_app_guide.Models._Interfaces
{
    public interface IRewardProvider
    {
        public int RewardDomainId { get; set; }

        public int DomainKey { get; set; }
        public int Quantity { get; set; }

        RewardDomain? RewardDomain { get; set; }
    }
}
