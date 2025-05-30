using System.Threading.Tasks;

namespace Prabh.Finance.Data;

public interface IFinanceDbSchemaMigrator
{
    Task MigrateAsync();
}
