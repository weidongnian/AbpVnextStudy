using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using SZYJ.Stroke.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SZYJ.Stroke.Web.Pages
{
    public abstract class StrokePage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<StrokeResource> L { get; set; }
    }
}
