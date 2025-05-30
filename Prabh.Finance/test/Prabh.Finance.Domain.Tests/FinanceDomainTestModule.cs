using Volo.Abp.Modularity;

namespace Prabh.Finance;

[DependsOn(
    typeof(FinanceDomainModule),
    typeof(FinanceTestBaseModule)
)]
public class FinanceDomainTestModule : AbpModule
{

}
