using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SZYJ.Stroke.Data
{
    /* This is used if database provider does't define
     * IStrokeDbSchemaMigrator implementation.
     */
    public class NullStrokeDbSchemaMigrator : IStrokeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}