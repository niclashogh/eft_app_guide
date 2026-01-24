using eft_app_guide.Models.Rewards;

namespace eft_app_guide.Models._Interfaces
{
    public interface IRewardProvider
    {
        string Description { get; set; }
        Reward? Reward { get; set; }
    }
}
