using eft_app_guide.Attributes;
using eft_app_guide.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide.Services
{
    [DependencyInjectionRegister(ServiceLifetime.Singleton)]
    public class TraceLogger
    {
        private readonly IDbContextFactory<DataContext> dbFactory;

        public TraceLogger(IDbContextFactory<DataContext> dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        private async Task Log()
        {
            // ...
        }
    }
}
