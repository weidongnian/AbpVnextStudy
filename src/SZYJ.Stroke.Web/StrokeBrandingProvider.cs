using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace SZYJ.Stroke.Web
{
    [Dependency(ReplaceServices = true)]
    public class StrokeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Stroke";
    }
}
