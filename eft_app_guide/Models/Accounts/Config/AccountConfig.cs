using eft_app_guide.Models.Accounts.State;
using eft_app_guide.Models.Characters.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Accounts.Config
{
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to AccountEdition
            builder
                .HasOne(x => x.AccountEdition)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => x.AccountEditionId);

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithOne(x => x.Account)
                .HasForeignKey<Character>(x => x.AccountId);
        }
    }
}
