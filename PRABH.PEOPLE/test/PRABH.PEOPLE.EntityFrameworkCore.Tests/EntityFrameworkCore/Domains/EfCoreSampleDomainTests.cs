using PRABH.PEOPLE.Samples;
using Xunit;

namespace PRABH.PEOPLE.EntityFrameworkCore.Domains;

[Collection(PEOPLETestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PEOPLEEntityFrameworkCoreTestModule>
{

}
