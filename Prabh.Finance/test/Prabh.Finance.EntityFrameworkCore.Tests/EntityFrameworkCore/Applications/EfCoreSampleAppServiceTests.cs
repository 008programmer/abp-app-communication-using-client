using Prabh.Finance.Samples;
using Xunit;

namespace Prabh.Finance.EntityFrameworkCore.Applications;

[Collection(FinanceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<FinanceEntityFrameworkCoreTestModule>
{

}
