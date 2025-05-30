using Xunit;

namespace Prabh.Finance.EntityFrameworkCore;

[CollectionDefinition(FinanceTestConsts.CollectionDefinitionName)]
public class FinanceEntityFrameworkCoreCollection : ICollectionFixture<FinanceEntityFrameworkCoreFixture>
{

}
