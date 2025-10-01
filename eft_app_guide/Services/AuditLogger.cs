using eft_app_guide.Attributes;
using eft_app_guide.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace eft_app_guide.Services
{
    [DependencyInjectionRegister(ServiceLifetime.Singleton)]
    public class AuditLogger
    {
        private readonly IDbContextFactory<DataContext> dbFactory;

        public AuditLogger(IDbContextFactory<DataContext> dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        private async Task Log(int entityId, AuditActions action, string forEntity, object? oldValues, object? newValues)
        {
            // ...
        }

        public async Task LogEntryChanged(int entityId, string forEntity, object oldValues, object newValues) => await Log(entityId, AuditActions.Changed, forEntity, oldValues, newValues);
        public async Task LogEntryCreation(int entityId, string forEntity, object newValues) => await Log(entityId, AuditActions.Created, forEntity, null, newValues);
        public async Task LogEntryRemoved(int entityId, string forEntity, object oldValues) => await Log(entityId, AuditActions.Removed, forEntity, oldValues, null);
        
        public async Task ClearEntireLog()
        {

        }

        public async Task RollbackChange()
        {
            // ...
        }

        public async Task RestoreEntry()
        {
            // ...
        }

        public async Task RemoveEntry()
        {
            // ...
        }
    }
}
