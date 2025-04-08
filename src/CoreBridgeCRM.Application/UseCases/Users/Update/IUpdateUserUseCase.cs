using CoreBridgeCRM.Communication.Requests;

namespace CoreBridgeCRM.Application.UseCases.Users.Update;
public interface IUpdateUserUseCase
{
    Task Execute(RequestUpdateUserJson request);
}
