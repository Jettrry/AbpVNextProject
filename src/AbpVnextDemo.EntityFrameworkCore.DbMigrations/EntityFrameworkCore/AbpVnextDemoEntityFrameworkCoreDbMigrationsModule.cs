using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpVnextDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpVnextDemoEntityFrameworkCoreModule)
        )]
    public class AbpVnextDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpVnextDemoMigrationsDbContext>();
        }
    }
}
