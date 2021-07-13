using Volo.Abp.Modularity;

namespace AbpVnextDemo
{
    [DependsOn(
        typeof(AbpVnextDemoApplicationModule),
        typeof(AbpVnextDemoDomainTestModule)
        )]
    public class AbpVnextDemoApplicationTestModule : AbpModule
    {

    }
}