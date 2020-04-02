using System.Threading.Tasks;

namespace SZYJ.Stroke.Data
{
    public interface IStrokeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
