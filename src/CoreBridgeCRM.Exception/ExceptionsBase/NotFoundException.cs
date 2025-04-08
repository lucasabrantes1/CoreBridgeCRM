﻿using System.Net;

namespace CoreBridgeCRM.Exception.ExceptionsBase;
public class NotFoundException : CoreBridgeCRMException
{
    public NotFoundException(string message) : base(message)
    {
    }

    public override int StatusCode => (int)HttpStatusCode.NotFound;

    public override List<string> GetErrors()
    {
        return [Message];
    }
}
