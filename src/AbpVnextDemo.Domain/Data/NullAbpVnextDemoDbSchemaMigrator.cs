using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpVnextDemo.Data
{
    /* This is used if database provider does't define
     * IAbpVnextDemoDbSchemaMigrator implementation.
     */
    public class NullAbpVnextDemoDbSchemaMigrator : IAbpVnextDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}