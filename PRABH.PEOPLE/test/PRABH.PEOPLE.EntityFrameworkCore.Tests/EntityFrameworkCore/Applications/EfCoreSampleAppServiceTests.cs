using PRABH.PEOPLE.Samples;
using Xunit;

namespace PRABH.PEOPLE.EntityFrameworkCore.Applications;

[Collection(PEOPLETestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PEOPLEEntityFrameworkCoreTestModule>
{

}
