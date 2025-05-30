using Volo.Abp.Modularity;

namespace Prabh.Finance;

[DependsOn(
    typeof(FinanceApplicationModule),
    typeof(FinanceDomainTestModule)
)]
public class FinanceApplicationTestModule : AbpModule
{

}
