using Prabh.Finance.Books;
using Xunit;

namespace Prabh.Finance.EntityFrameworkCore.Applications.Books;

[Collection(FinanceTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<FinanceEntityFrameworkCoreTestModule>
{

}