using SZYJ.Stroke.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SZYJ.Stroke
{
    [DependsOn(
        typeof(StrokeEntityFrameworkCoreTestModule)
        )]
    public class StrokeDomainTestModule : AbpModule
    {

    }
}