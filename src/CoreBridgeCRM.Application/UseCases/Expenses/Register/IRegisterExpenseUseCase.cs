using CoreBridgeCRM.Communication.Requests;
using CoreBridgeCRM.Communication.Responses;

namespace CoreBridgeCRM.Application.UseCases.Expenses.Register;
public interface IRegisterExpenseUseCase
{
    Task<ResponseRegisteredExpenseJson> Execute(RequestExpenseJson request);
}
