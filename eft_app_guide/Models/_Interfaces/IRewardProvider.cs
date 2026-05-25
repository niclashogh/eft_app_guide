using eft_app_guide._Persistence.Entities.TargetTypes;

namespace eft_app_guide.Models._Interfaces
{
    public interface IRewardProvider
    {
        public int RewardTargetTypeId { get; set; }

        public int TargetKey { get; set; }
        public int Quantity { get; set; }

        public RewardTargetType? RewardTargetType { get; set; }
    }
}
