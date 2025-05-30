using Volo.Abp.Modularity;

namespace Prabh.Stock;

[DependsOn(
    typeof(StockDomainModule),
    typeof(StockTestBaseModule)
)]
public class StockDomainTestModule : AbpModule
{

}
