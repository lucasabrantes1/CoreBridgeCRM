using CoreBridgeCRM.Domain.Entities;

namespace CoreBridgeCRM.Domain.Repositories.Expenses;
public interface IExpensesUpdateOnlyRepository
{
    Task<Expense?> GetById(Entities.User user, long id);
    void Update(Expense expense);
}
