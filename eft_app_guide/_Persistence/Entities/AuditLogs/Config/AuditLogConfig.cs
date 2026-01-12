using eft_app_guide._Persistence.Entities.AuditLogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.AuditLogs.Config
{
    public class AuditLogConfig : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.HasKey(x => x.Id);

            // Link AuditLog to Parent
            builder
                .HasOne(x => x.Parent)
                .WithMany(x => x.AssociatedLogs)
                .HasForeignKey(x => x.ParentId);
        }
    }
}
