using Prabh.Stock.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Prabh.Stock.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StockEntityFrameworkCoreModule),
    typeof(StockApplicationContractsModule)
)]
public class StockDbMigratorModule : AbpModule
{
}
