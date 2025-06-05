using Microsoft.Extensions.DependencyInjection;
using Prabh.News;
using Prabh.Stock;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Http.Client;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.VirtualFileSystem;

namespace Prabh.Finance;

[DependsOn(
    typeof(FinanceApplicationContractsModule),
    typeof(AbpHttpClientModule),
    typeof(AbpPermissionManagementHttpApiClientModule),
    typeof(AbpFeatureManagementHttpApiClientModule),
    typeof(AbpAccountHttpApiClientModule),
    typeof(AbpIdentityHttpApiClientModule),
    typeof(AbpTenantManagementHttpApiClientModule),
    typeof(AbpSettingManagementHttpApiClientModule),
    typeof(StockHttpApiClientModule),
    typeof(NewsHttpApiClientModule)
)]
public class FinanceHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Finance";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddStaticHttpClientProxies(
            typeof(FinanceApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<FinanceHttpApiClientModule>();
        });
    }
}
