using CoreBridgeCRM.Domain.Entities;

namespace CoreBridgeCRM.Domain.Security.Tokens;
public interface IAccessTokenGenerator
{
    string Generate(User user);
}
