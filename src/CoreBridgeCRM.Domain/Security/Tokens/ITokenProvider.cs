namespace CoreBridgeCRM.Domain.Security.Tokens;
public interface ITokenProvider
{
    string TokenOnRequest();
}
