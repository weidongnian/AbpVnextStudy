using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SZYJ.Stroke.EntityFrameworkCore
{
    [DependsOn(
        typeof(StrokeEntityFrameworkCoreModule)
        )]
    public class StrokeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<StrokeMigrationsDbContext>();
        }
    }
}
