using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PRABH.PROJECTS.Data;
using Volo.Abp.DependencyInjection;

namespace PRABH.PROJECTS.EntityFrameworkCore;

public class EntityFrameworkCorePROJECTSDbSchemaMigrator
    : IPROJECTSDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePROJECTSDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the PROJECTSDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PROJECTSDbContext>()
            .Database
            .MigrateAsync();
    }
}
