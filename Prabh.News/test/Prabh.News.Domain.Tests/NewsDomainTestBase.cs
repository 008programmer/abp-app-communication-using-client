using Volo.Abp.Modularity;

namespace Prabh.News;

/* Inherit from this class for your domain layer tests. */
public abstract class NewsDomainTestBase<TStartupModule> : NewsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
