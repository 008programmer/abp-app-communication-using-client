using Prabh.Stock.Books;
using Xunit;

namespace Prabh.Stock.EntityFrameworkCore.Applications.Books;

[Collection(StockTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<StockEntityFrameworkCoreTestModule>
{

}