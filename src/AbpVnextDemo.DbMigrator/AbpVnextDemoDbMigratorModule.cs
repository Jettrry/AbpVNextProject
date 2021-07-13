using AbpVnextDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpVnextDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpVnextDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpVnextDemoApplicationContractsModule)
        )]
    public class AbpVnextDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
