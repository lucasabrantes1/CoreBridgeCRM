using CoreBridgeCRM.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoreBridgeCRM.Infrastructure.Migrations;
public static class DataBaseMigration
{
    public async static Task MigrateDatabase(IServiceProvider serviceProvider)
    {
        var dbContext = serviceProvider.GetRequiredService<CoreBridgeCRMDbContext>();

        await dbContext.Database.MigrateAsync();
    }
}
