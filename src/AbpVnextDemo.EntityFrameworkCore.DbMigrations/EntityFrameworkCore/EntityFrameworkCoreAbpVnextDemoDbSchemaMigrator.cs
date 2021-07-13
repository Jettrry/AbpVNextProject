using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpVnextDemo.Data;
using Volo.Abp.DependencyInjection;

namespace AbpVnextDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpVnextDemoDbSchemaMigrator
        : IAbpVnextDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpVnextDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpVnextDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpVnextDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}