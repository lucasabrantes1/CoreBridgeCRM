using CoreBridgeCRM.Domain.Entities;

namespace CoreBridgeCRM.Domain.Services.LoggedUser;
public interface ILoggedUser
{
    Task<User> Get();
}
