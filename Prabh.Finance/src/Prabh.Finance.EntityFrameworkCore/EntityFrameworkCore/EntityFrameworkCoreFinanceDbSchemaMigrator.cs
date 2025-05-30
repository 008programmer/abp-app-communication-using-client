using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Prabh.Finance.Data;
using Volo.Abp.DependencyInjection;

namespace Prabh.Finance.EntityFrameworkCore;

public class EntityFrameworkCoreFinanceDbSchemaMigrator
    : IFinanceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFinanceDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the FinanceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FinanceDbContext>()
            .Database
            .MigrateAsync();
    }
}
