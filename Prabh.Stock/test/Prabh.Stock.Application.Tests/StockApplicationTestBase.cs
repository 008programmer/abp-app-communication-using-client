using Volo.Abp.Modularity;

namespace Prabh.Stock;

public abstract class StockApplicationTestBase<TStartupModule> : StockTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
