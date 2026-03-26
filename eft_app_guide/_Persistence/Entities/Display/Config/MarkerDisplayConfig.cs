using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide._Persistence.Entities.Display.Config
{
    public class MarkerDisplayConfig : IEntityTypeConfiguration<MarkerDisplay>
    {
        public void Configure(EntityTypeBuilder<MarkerDisplay> builder) // TODO
        {
            builder.HasKey(x => x.Id);

            // Link @ to MapDisplay
        }
    }
}
