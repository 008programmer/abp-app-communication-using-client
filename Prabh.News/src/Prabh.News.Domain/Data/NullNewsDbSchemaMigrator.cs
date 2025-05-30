using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Prabh.News.Data;

/* This is used if database provider does't define
 * INewsDbSchemaMigrator implementation.
 */
public class NullNewsDbSchemaMigrator : INewsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
