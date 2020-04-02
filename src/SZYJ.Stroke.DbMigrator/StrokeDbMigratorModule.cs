using SZYJ.Stroke.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SZYJ.Stroke.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(StrokeEntityFrameworkCoreDbMigrationsModule),
        typeof(StrokeApplicationContractsModule)
        )]
    public class StrokeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
