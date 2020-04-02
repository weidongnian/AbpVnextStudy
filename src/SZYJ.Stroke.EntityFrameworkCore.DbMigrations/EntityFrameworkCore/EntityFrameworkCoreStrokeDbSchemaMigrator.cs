using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SZYJ.Stroke.Data;
using Volo.Abp.DependencyInjection;

namespace SZYJ.Stroke.EntityFrameworkCore
{
    public class EntityFrameworkCoreStrokeDbSchemaMigrator
        : IStrokeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreStrokeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the StrokeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<StrokeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}