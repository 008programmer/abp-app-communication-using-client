using Volo.Abp.Modularity;

namespace Prabh.Stock;

[DependsOn(
    typeof(StockApplicationModule),
    typeof(StockDomainTestModule)
)]
public class StockApplicationTestModule : AbpModule
{

}
