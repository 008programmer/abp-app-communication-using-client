using Prabh.News.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Prabh.News.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NewsEntityFrameworkCoreModule),
    typeof(NewsApplicationContractsModule)
)]
public class NewsDbMigratorModule : AbpModule
{
}
