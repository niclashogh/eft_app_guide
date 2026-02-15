using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterStationProgressConfig : IEntityTypeConfiguration<CharacterStationProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterStationProgress> builder) // MISSING
        {
            throw new NotImplementedException();
        }
    }
}
