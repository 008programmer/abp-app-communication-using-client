using Prabh.Finance.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Prabh.Finance.Permissions;

public class FinancePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FinancePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(FinancePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(FinancePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(FinancePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(FinancePermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FinancePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FinanceResource>(name);
    }
}
