using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterMapAccessConfig : IEntityTypeConfiguration<CharacterMapAccess>
    {
        public void Configure(EntityTypeBuilder<CharacterMapAccess> builder) // MISSING
        {
            throw new NotImplementedException();
        }
    }
}
