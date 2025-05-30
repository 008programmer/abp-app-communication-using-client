using Prabh.Stock.Samples;
using Xunit;

namespace Prabh.Stock.EntityFrameworkCore.Domains;

[Collection(StockTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StockEntityFrameworkCoreTestModule>
{

}
