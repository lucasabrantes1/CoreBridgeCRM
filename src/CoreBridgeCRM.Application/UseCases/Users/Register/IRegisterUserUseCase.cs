using CoreBridgeCRM.Communication.Requests;
using CoreBridgeCRM.Communication.Responses;

namespace CoreBridgeCRM.Application.UseCases.Users.Register;
public interface IRegisterUserUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestRegisterUserJson request);
}
