using Volo.Abp.Modularity;

namespace PRABH.PROJECTS;

/* Inherit from this class for your domain layer tests. */
public abstract class PROJECTSDomainTestBase<TStartupModule> : PROJECTSTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
