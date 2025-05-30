using Prabh.News.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Prabh.News.Permissions;

public class NewsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NewsPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(NewsPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(NewsPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(NewsPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(NewsPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NewsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NewsResource>(name);
    }
}
