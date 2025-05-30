using Prabh.Finance.Samples;
using Xunit;

namespace Prabh.Finance.EntityFrameworkCore.Domains;

[Collection(FinanceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<FinanceEntityFrameworkCoreTestModule>
{

}
