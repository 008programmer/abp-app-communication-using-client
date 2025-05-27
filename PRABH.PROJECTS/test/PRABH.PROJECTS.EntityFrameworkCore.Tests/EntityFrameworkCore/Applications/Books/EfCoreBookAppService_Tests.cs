using PRABH.PROJECTS.Books;
using Xunit;

namespace PRABH.PROJECTS.EntityFrameworkCore.Applications.Books;

[Collection(PROJECTSTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<PROJECTSEntityFrameworkCoreTestModule>
{

}