using Prabh.News.Samples;
using Xunit;

namespace Prabh.News.EntityFrameworkCore.Domains;

[Collection(NewsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<NewsEntityFrameworkCoreTestModule>
{

}
