using System.Threading.Tasks;

namespace Prabh.Stock.Data;

public interface IStockDbSchemaMigrator
{
    Task MigrateAsync();
}
