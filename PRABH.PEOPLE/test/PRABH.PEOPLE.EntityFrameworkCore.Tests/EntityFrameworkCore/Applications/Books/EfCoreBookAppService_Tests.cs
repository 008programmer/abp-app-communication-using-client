using PRABH.PEOPLE.Books;
using Xunit;

namespace PRABH.PEOPLE.EntityFrameworkCore.Applications.Books;

[Collection(PEOPLETestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<PEOPLEEntityFrameworkCoreTestModule>
{

}