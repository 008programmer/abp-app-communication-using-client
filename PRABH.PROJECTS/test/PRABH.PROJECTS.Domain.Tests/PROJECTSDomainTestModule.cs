using Volo.Abp.Modularity;

namespace PRABH.PROJECTS;

[DependsOn(
    typeof(PROJECTSDomainModule),
    typeof(PROJECTSTestBaseModule)
)]
public class PROJECTSDomainTestModule : AbpModule
{

}
