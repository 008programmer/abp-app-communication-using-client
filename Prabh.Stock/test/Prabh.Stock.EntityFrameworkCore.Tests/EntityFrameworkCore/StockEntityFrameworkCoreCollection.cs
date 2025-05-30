using Xunit;

namespace Prabh.Stock.EntityFrameworkCore;

[CollectionDefinition(StockTestConsts.CollectionDefinitionName)]
public class StockEntityFrameworkCoreCollection : ICollectionFixture<StockEntityFrameworkCoreFixture>
{

}
