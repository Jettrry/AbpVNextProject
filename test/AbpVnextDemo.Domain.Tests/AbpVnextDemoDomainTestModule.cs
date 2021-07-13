using AbpVnextDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpVnextDemo
{
    [DependsOn(
        typeof(AbpVnextDemoEntityFrameworkCoreTestModule)
        )]
    public class AbpVnextDemoDomainTestModule : AbpModule
    {

    }
}