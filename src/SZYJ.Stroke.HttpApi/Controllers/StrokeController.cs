using SZYJ.Stroke.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SZYJ.Stroke.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class StrokeController : AbpController
    {
        protected StrokeController()
        {
            LocalizationResource = typeof(StrokeResource);
        }
    }
}