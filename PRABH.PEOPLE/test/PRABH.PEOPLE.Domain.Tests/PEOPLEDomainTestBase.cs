using Volo.Abp.Modularity;

namespace PRABH.PEOPLE;

/* Inherit from this class for your domain layer tests. */
public abstract class PEOPLEDomainTestBase<TStartupModule> : PEOPLETestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
