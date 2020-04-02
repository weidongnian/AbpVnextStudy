using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SZYJ.Stroke.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(StrokeHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class StrokeConsoleApiClientModule : AbpModule
    {
        
    }
}
