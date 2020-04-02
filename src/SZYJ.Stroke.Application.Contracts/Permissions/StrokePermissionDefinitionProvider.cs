using SZYJ.Stroke.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SZYJ.Stroke.Permissions
{
    public class StrokePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(StrokePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(StrokePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<StrokeResource>(name);
        }
    }
}
