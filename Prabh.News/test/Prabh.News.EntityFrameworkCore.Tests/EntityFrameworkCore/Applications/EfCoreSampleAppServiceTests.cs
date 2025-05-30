using Prabh.News.Samples;
using Xunit;

namespace Prabh.News.EntityFrameworkCore.Applications;

[Collection(NewsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<NewsEntityFrameworkCoreTestModule>
{

}
