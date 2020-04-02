using System;
using System.Collections.Generic;
using System.Text;
using SZYJ.Stroke.Localization;
using Volo.Abp.Application.Services;

namespace SZYJ.Stroke
{
    /* Inherit your application services from this class.
     */
    public abstract class StrokeAppService : ApplicationService
    {
        protected StrokeAppService()
        {
            LocalizationResource = typeof(StrokeResource);
        }
    }
}
