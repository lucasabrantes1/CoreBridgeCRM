using CoreBridgeCRM.Domain.Entities;

namespace CoreBridgeCRM.Domain.Repositories.Expenses;
public interface IExpensesWriteOnlyRepository
{
    Task Add(Expense expense);
    Task Delete(long id);
}
