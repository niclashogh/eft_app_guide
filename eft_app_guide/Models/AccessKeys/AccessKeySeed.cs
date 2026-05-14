using eft_app_guide.Models.AccessKeys.Design;

namespace eft_app_guide.Models.AccessKeys
{
    public static class AccessKeySeed
    {
        public static IEnumerable<AccessKey> GetAccessKeys()
        {
            yield return new AccessKey();
            // ...
        }
    }
}
