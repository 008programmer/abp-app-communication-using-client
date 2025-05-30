using System.Threading.Tasks;

namespace Prabh.News.Data;

public interface INewsDbSchemaMigrator
{
    Task MigrateAsync();
}
