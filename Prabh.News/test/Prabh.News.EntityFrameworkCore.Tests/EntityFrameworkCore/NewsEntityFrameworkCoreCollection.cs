using Xunit;

namespace Prabh.News.EntityFrameworkCore;

[CollectionDefinition(NewsTestConsts.CollectionDefinitionName)]
public class NewsEntityFrameworkCoreCollection : ICollectionFixture<NewsEntityFrameworkCoreFixture>
{

}
