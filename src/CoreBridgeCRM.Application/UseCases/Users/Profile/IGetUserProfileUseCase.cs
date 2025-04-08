using CoreBridgeCRM.Communication.Responses;

namespace CoreBridgeCRM.Application.UseCases.Users.Profile;
public interface IGetUserProfileUseCase
{
    Task<ResponseUserProfileJson> Execute();
}
