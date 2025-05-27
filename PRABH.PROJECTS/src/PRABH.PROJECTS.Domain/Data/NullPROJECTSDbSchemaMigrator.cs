using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PRABH.PROJECTS.Data;

/* This is used if database provider does't define
 * IPROJECTSDbSchemaMigrator implementation.
 */
public class NullPROJECTSDbSchemaMigrator : IPROJECTSDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
