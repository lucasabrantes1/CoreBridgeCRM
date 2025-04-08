using CoreBridgeCRM.Communication.Requests;

namespace CoreBridgeCRM.Application.UseCases.Expenses.Update;
public interface IUpdateExpenseUseCase
{
    Task Execute(long id, RequestExpenseJson request);
}
