using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Prabh.Stock.Data;

/* This is used if database provider does't define
 * IStockDbSchemaMigrator implementation.
 */
public class NullStockDbSchemaMigrator : IStockDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
