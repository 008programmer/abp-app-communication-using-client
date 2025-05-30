using Volo.Abp.Modularity;

namespace Prabh.Finance;

public abstract class FinanceApplicationTestBase<TStartupModule> : FinanceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
