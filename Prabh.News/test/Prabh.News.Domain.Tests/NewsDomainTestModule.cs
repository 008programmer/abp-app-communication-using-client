using Volo.Abp.Modularity;

namespace Prabh.News;

[DependsOn(
    typeof(NewsDomainModule),
    typeof(NewsTestBaseModule)
)]
public class NewsDomainTestModule : AbpModule
{

}
