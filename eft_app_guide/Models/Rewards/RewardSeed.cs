using eft_app_guide.Models.Rewards.Design;

namespace eft_app_guide.Models.Rewards
{
    public static class RewardSeed
    {
        public static IEnumerable<RewardDomain> GetDomains()
        {
            yield return new RewardDomain();
            // ... for items, map-access, traders, etc.
        }
    }
}
