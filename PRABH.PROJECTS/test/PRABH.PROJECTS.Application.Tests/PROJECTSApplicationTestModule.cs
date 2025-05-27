using Volo.Abp.Modularity;

namespace PRABH.PROJECTS;

[DependsOn(
    typeof(PROJECTSApplicationModule),
    typeof(PROJECTSDomainTestModule)
)]
public class PROJECTSApplicationTestModule : AbpModule
{

}
