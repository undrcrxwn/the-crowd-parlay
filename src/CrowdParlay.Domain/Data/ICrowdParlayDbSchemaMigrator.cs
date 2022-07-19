using System.Threading.Tasks;

namespace CrowdParlay.Data;

public interface ICrowdParlayDbSchemaMigrator
{
    Task MigrateAsync();
}
