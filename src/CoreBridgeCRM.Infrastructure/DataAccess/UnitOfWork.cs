using CoreBridgeCRM.Domain.Repositories;

namespace CoreBridgeCRM.Infrastructure.DataAccess;
internal class UnitOfWork : IUnitOfWork
{
    private readonly CoreBridgeCRMDbContext _dbContext;
    public UnitOfWork(CoreBridgeCRMDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Commit() => await _dbContext.SaveChangesAsync();
}
