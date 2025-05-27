using System.Threading.Tasks;

namespace PRABH.PROJECTS.Data;

public interface IPROJECTSDbSchemaMigrator
{
    Task MigrateAsync();
}
