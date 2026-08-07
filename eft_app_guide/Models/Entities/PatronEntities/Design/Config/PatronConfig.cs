using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.PatronEntities.Design.Config
{
    public class PatronConfig : IEntityTypeConfiguration<Patron>
    {
        public void Configure(EntityTypeBuilder<Patron> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to PatronLevel
            builder
                .HasMany(x => x.PatronLevels)
                .WithOne(x => x.Patron)
                .HasForeignKey(x => x.PatronId);

            // Link @ to PatronCurreny
            builder
                .HasMany(x => x.PatronCurrencies)
                .WithOne(x => x.Patron)
                .HasForeignKey(x => x.PatronId);

            // Link @ to Quest
            builder
                .HasMany(x => x.Quests)
                .WithOne(x => x.Patron)
                .HasForeignKey(x => x.PatronId);

            // Link @ to CharacterPatronReputation
            builder
                .HasMany(x => x.CharacterPatronProgressions)
                .WithOne(x => x.Patron)
                .HasForeignKey(x => x.PatronId);
        }
    }
}
