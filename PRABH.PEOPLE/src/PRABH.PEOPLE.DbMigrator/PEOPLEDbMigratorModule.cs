using PRABH.PEOPLE.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PRABH.PEOPLE.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PEOPLEEntityFrameworkCoreModule),
    typeof(PEOPLEApplicationContractsModule)
)]
public class PEOPLEDbMigratorModule : AbpModule
{
}
