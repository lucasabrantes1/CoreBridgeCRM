using CoreBridgeCRM.Communication.Requests;
using CoreBridgeCRM.Communication.Responses;

namespace CoreBridgeCRM.Application.UseCases.Login.DoLogin;
public interface IDoLoginUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestLoginJson request);
}
