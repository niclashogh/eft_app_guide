using eft_app_guide.Models._Internal.Config;
using eft_app_guide.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._Internal
{
    [EntityTypeConfiguration(typeof(AuditLogConfig))]
    public class AuditLog
    {
        #region Keys
        [Key] public int Id { get; set; }
        public int? ParentId { get; set; }
        #endregion

        [Required] public DateTime ChangedDate { get; set; }
        public DateTime? RollbackDate { get; set; }

        [Required] public AuditActions Action { get; set; }
        [Required] public string ForEntity { get; set; }

        public string? OldValues { get; set; }
        public string? NewValues { get; set; }

        #region Relations
        public AuditLog? Parent { get; set; }
        public List<AuditLog> AssociatedLogs { get; set; } = new();
        #endregion
    }
}
