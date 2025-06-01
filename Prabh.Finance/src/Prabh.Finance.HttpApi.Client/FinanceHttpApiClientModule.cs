using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.TenantManagement;
//using Prabh.Stock;

namespace Prabh.Finance;

[DependsOn(
    typeof(FinanceApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiClientModule),
    typeof(AbpFeatureManagementHttpApiClientModule),
    typeof(AbpAccountHttpApiClientModule),
    typeof(AbpIdentityHttpApiClientModule),
    typeof(AbpTenantManagementHttpApiClientModule),
    typeof(AbpSettingManagementHttpApiClientModule)
    //typeof(StockHttpApiClientModule)
)]
public class FinanceHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(FinanceApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        //context.Services.AddHttpClientProxies(
        //    typeof(StockApplicationContractsModule).Assembly,
        //    "stocks"
        //);

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<FinanceHttpApiClientModule>();
        });
    }
}
