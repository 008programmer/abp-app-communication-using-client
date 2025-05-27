using System.Threading.Tasks;

namespace PRABH.PEOPLE.Data;

public interface IPEOPLEDbSchemaMigrator
{
    Task MigrateAsync();
}
