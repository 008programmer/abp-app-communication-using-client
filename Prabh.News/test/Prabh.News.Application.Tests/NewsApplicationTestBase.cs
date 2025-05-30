using Volo.Abp.Modularity;

namespace Prabh.News;

public abstract class NewsApplicationTestBase<TStartupModule> : NewsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
