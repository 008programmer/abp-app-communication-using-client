using Volo.Abp.Modularity;

namespace Prabh.Finance;

/* Inherit from this class for your domain layer tests. */
public abstract class FinanceDomainTestBase<TStartupModule> : FinanceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
