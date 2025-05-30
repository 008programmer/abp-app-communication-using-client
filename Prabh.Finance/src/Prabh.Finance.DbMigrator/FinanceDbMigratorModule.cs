using Prabh.Finance.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Prabh.Finance.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FinanceEntityFrameworkCoreModule),
    typeof(FinanceApplicationContractsModule)
)]
public class FinanceDbMigratorModule : AbpModule
{
}
