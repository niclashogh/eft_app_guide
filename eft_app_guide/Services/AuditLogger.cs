using eft_app_guide.Models.Enums;

namespace eft_app_guide.Services
{
    public static class AuditLogger
    {
        private static async Task Log(int entityId, AuditActions action, string forEntity, object? oldValues, object? newValues)
        {
            // ...
        }

        public static async Task LogEntryChanged(int entityId, string forEntity, object oldValues, object newValues) => await Log(entityId, AuditActions.Changed, forEntity, oldValues, newValues);
        public static async Task LogEntryCreation(int entityId, string forEntity, object newValues) => await Log(entityId, AuditActions.Created, forEntity, null, newValues);
        public static async Task LogEntryRemoved(int entityId, string forEntity, object oldValues) => await Log(entityId, AuditActions.Removed, forEntity, oldValues, null);
        
        public static async Task ClearEntireLog()
        {

        }

        public static async Task RollbackChange()
        {
            // ...
        }

        public static async Task RestoreEntry()
        {
            // ...
        }

        public static async Task RemoveEntry()
        {
            // ...
        }
    }
}
