using PRABH.PROJECTS.Samples;
using Xunit;

namespace PRABH.PROJECTS.EntityFrameworkCore.Domains;

[Collection(PROJECTSTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PROJECTSEntityFrameworkCoreTestModule>
{

}
