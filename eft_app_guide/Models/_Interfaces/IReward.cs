using eft_app_guide.Models._Enums;

namespace eft_app_guide.Models._Interfaces
{
    public interface IReward
    {
        string Description { get; set; }
        RewardTypes Type { get; set; }
        int TypeKey { get; set; }
        int Amount { get; set; }
    }
}
