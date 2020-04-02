using SZYJ.Stroke.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SZYJ.Stroke.Web.Pages
{
    public abstract class StrokePageModel : AbpPageModel
    {
        protected StrokePageModel()
        {
            LocalizationResourceType = typeof(StrokeResource);
        }
    }
}