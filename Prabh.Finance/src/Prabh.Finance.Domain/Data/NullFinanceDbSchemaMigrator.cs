using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Prabh.Finance.Data;

/* This is used if database provider does't define
 * IFinanceDbSchemaMigrator implementation.
 */
public class NullFinanceDbSchemaMigrator : IFinanceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
