using Prabh.Stock.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Prabh.Stock.Permissions;

public class StockPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StockPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(StockPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(StockPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(StockPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(StockPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StockPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StockResource>(name);
    }
}
