using Volo.Abp.Modularity;

namespace Prabh.News;

[DependsOn(
    typeof(NewsApplicationModule),
    typeof(NewsDomainTestModule)
)]
public class NewsApplicationTestModule : AbpModule
{

}
