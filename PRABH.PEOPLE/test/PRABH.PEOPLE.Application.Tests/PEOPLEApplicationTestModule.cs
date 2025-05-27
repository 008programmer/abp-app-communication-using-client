using Volo.Abp.Modularity;

namespace PRABH.PEOPLE;

[DependsOn(
    typeof(PEOPLEApplicationModule),
    typeof(PEOPLEDomainTestModule)
)]
public class PEOPLEApplicationTestModule : AbpModule
{

}
