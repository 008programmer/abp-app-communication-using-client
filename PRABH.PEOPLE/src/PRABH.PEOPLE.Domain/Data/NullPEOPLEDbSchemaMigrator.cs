using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PRABH.PEOPLE.Data;

/* This is used if database provider does't define
 * IPEOPLEDbSchemaMigrator implementation.
 */
public class NullPEOPLEDbSchemaMigrator : IPEOPLEDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
