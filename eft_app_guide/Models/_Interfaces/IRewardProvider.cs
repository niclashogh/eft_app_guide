using eft_app_guide._Persistence.Entities.RewardDomain;

namespace eft_app_guide.Models._Interfaces
{
    public interface IRewardProvider
    {
        public int RewardDomainId { get; set; }

        public int DomainKey { get; set; }
        public int Quantity { get; set; }

        public RewardDomain? RewardDomain { get; set; }
    }
}
