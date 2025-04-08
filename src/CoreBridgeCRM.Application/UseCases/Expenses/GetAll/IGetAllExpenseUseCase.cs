using CoreBridgeCRM.Communication.Responses;

namespace CoreBridgeCRM.Application.UseCases.Expenses.GetAll;
public interface IGetAllExpenseUseCase
{
    Task<ResponseExpensesJson> Execute();
}
