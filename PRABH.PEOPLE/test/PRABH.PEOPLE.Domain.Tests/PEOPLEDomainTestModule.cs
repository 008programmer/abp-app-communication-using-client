using Volo.Abp.Modularity;

namespace PRABH.PEOPLE;

[DependsOn(
    typeof(PEOPLEDomainModule),
    typeof(PEOPLETestBaseModule)
)]
public class PEOPLEDomainTestModule : AbpModule
{

}
