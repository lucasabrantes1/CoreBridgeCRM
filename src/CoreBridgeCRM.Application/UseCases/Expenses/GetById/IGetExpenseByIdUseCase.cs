using CoreBridgeCRM.Communication.Responses;

namespace CoreBridgeCRM.Application.UseCases.Expenses.GetById;
public interface IGetExpenseByIdUseCase
{
    Task<ResponseExpenseJson> Execute(long id);
}
