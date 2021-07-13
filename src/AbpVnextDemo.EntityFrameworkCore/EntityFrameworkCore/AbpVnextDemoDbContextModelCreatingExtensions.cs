using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpVnextDemo.EntityFrameworkCore
{
    public static class AbpVnextDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpVnextDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpVnextDemoConsts.DbTablePrefix + "YourEntities", AbpVnextDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}