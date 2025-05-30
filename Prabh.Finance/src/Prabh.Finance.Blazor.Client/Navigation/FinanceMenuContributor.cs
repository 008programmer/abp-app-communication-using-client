using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Prabh.Finance.Localization;
using Prabh.Finance.Permissions;
using Prabh.Finance.MultiTenancy;
using Volo.Abp.Account.Localization;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.Users;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.Identity.Blazor;

namespace Prabh.Finance.Blazor.Client.Navigation;

public class FinanceMenuContributor : IMenuContributor
{
    private readonly IConfiguration _configuration;

    public FinanceMenuContributor(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
        else if (context.Menu.Name == StandardMenus.User)
        {
            await ConfigureUserMenuAsync(context);
        }
    }

    private static async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<FinanceResource>();
        
        //Administration
        var administration = context.Menu.GetAdministration();
        administration.Order = 6;

        context.Menu.AddItem(new ApplicationMenuItem(
            FinanceMenus.Home,
            l["Menu:Home"],
            "/",
            icon: "fas fa-home",
            order: 1
        ));
        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);
    
        //var bookStoreMenu = new ApplicationMenuItem(
        //    "BooksStore",
        //    "Stocks",
        //    url: "/books",
        //    icon: "fa fa-book",1,null,null,
        //);
        var bookStoreMenu = new ApplicationMenuItem(
            "BooksStore.Books",
            "Stocks",
            url: "/books"
        );

        context.Menu.AddItem(bookStoreMenu);

        //CHECK the PERMISSION
        //if (await context.IsGrantedAsync(FinancePermissions.Books.Default))
        //{
            //bookStoreMenu.AddItem(new ApplicationMenuItem(
            //    "BooksStore.Books",
            //    "Stocks",
            //    url: "/books"
            //));

        //bookStoreMenu.AddItem(new ApplicationMenuItem(
        //        "BooksStore.Books",
        //        "News (Coming soon)"
        //    ));
        ////}        //}
    }

    private async Task ConfigureUserMenuAsync(MenuConfigurationContext context)
    {
        var accountStringLocalizer = context.GetLocalizer<AccountResource>();
        var authServerUrl = _configuration["AuthServer:Authority"] ?? "";

        context.Menu.AddItem(new ApplicationMenuItem(
            "Account.Manage",
            accountStringLocalizer["MyAccount"],
            $"{authServerUrl.EnsureEndsWith('/')}Account/Manage",
            icon: "fa fa-cog",
            order: 1000,
            target: "_blank").RequireAuthenticated());

        await Task.CompletedTask;
    }
}
