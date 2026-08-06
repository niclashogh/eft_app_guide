using eft_app_guide.Models.Entities.HIdeouts.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.HIdeouts.Design.Config
{
    public class HideoutConfig : IEntityTypeConfiguration<Hideout> // TODO
    {
        public void Configure(EntityTypeBuilder<Hideout> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.HideoutVariant);

            // Link @ to Workstation

            // Link @ to HideoutCharacter
        }
    }
}
