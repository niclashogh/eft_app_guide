using eft_app_guide.Models.Accounts.Design;

namespace eft_app_guide.Models.Accounts
{
    public static class AccountSeed
    {
        public static IEnumerable<string> GetEditions()
        {
            yield return "Standard";
            yield return "Left Behind";
            yield return "Prepare for Escape";
            yield return "Edge of Darkness";
            yield return "The Unheard";
        }

        public static IEnumerable<AccountEditionReward> GetEditionRewards()
        {
            yield return new AccountEditionReward();
            // ...
        }
    }
}
