using Volo.Abp.Modularity;

namespace Prabh.Stock;

/* Inherit from this class for your domain layer tests. */
public abstract class StockDomainTestBase<TStartupModule> : StockTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
