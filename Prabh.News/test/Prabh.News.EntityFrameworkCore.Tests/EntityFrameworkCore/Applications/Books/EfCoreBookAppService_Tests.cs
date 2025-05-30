using Prabh.News.Books;
using Xunit;

namespace Prabh.News.EntityFrameworkCore.Applications.Books;

[Collection(NewsTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<NewsEntityFrameworkCoreTestModule>
{

}