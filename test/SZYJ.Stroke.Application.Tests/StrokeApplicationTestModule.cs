using Volo.Abp.Modularity;

namespace SZYJ.Stroke
{
    [DependsOn(
        typeof(StrokeApplicationModule),
        typeof(StrokeDomainTestModule)
        )]
    public class StrokeApplicationTestModule : AbpModule
    {

    }
}