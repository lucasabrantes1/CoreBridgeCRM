namespace CoreBridgeCRM.Exception.ExceptionsBase;
public abstract class CoreBridgeCRMException : SystemException
{
    protected CoreBridgeCRMException(string message) : base(message)
    {
        
    }

    public abstract int StatusCode { get; }
    public abstract List<string> GetErrors();
}
