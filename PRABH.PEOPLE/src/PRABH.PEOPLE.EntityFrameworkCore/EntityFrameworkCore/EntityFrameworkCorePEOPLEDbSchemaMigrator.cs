using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PRABH.PEOPLE.Data;
using Volo.Abp.DependencyInjection;

namespace PRABH.PEOPLE.EntityFrameworkCore;

public class EntityFrameworkCorePEOPLEDbSchemaMigrator
    : IPEOPLEDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePEOPLEDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the PEOPLEDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PEOPLEDbContext>()
            .Database
            .MigrateAsync();
    }
}
