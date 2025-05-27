using PRABH.PEOPLE.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace PRABH.PEOPLE.Permissions;

public class PEOPLEPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PEOPLEPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(PEOPLEPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(PEOPLEPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(PEOPLEPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(PEOPLEPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PEOPLEPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PEOPLEResource>(name);
    }
}
