using Prabh.Stock.Samples;
using Xunit;

namespace Prabh.Stock.EntityFrameworkCore.Applications;

[Collection(StockTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StockEntityFrameworkCoreTestModule>
{

}
