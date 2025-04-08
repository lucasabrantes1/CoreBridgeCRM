using System.Net;

namespace CoreBridgeCRM.Exception.ExceptionsBase;
public class InvalidLoginException : CoreBridgeCRMException
{
    public InvalidLoginException() : base(ResourceErrorMessages.EMAIL_OR_PASSWORD_INVALID)
    {
    }

    public override int StatusCode => (int)HttpStatusCode.Unauthorized;

    public override List<string> GetErrors()
    {
        return [Message];
    }
}
