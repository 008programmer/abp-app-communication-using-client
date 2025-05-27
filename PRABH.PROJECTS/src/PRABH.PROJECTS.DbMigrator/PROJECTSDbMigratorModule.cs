using PRABH.PROJECTS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PRABH.PROJECTS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PROJECTSEntityFrameworkCoreModule),
    typeof(PROJECTSApplicationContractsModule)
)]
public class PROJECTSDbMigratorModule : AbpModule
{
}
