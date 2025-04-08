using CoreBridgeCRM.Communication.Requests;

namespace CoreBridgeCRM.Application.UseCases.Users.ChangePassword;
public interface IChangePasswordUseCase
{
    Task Execute(RequestChangePasswordJson request);
}
