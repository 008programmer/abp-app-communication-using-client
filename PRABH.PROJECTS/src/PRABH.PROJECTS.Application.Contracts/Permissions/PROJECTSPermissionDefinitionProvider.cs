using PRABH.PROJECTS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace PRABH.PROJECTS.Permissions;

public class PROJECTSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PROJECTSPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(PROJECTSPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(PROJECTSPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(PROJECTSPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(PROJECTSPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PROJECTSPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PROJECTSResource>(name);
    }
}
