using PRABH.PROJECTS.Samples;
using Xunit;

namespace PRABH.PROJECTS.EntityFrameworkCore.Applications;

[Collection(PROJECTSTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PROJECTSEntityFrameworkCoreTestModule>
{

}
