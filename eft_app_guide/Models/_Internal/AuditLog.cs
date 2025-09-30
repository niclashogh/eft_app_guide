using eft_app_guide.Services;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._Internal
{
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

        public object? OldValues { get; set; }
        public object? NewValues { get; set; }

        #region Relations
        public AuditLog? Parent { get; set; }
        public List<AuditLog> AssociatedLogs { get; set; } = new();
        #endregion
    }
}
