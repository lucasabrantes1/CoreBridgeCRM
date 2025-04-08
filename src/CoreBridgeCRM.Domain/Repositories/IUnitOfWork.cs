namespace CoreBridgeCRM.Domain.Repositories;
public interface IUnitOfWork
{
    Task Commit();
}
