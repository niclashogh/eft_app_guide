using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Rewards.Config
{
    public class RewardDomainConfig : IEntityTypeConfiguration<RewardDomain>
    {
        public void Configure(EntityTypeBuilder<RewardDomain> builder) // MISSING
        {
            throw new NotImplementedException();
        }
    }
}
