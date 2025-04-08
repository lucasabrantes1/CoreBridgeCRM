using CoreBridgeCRM.Communication.Responses;
using CoreBridgeCRM.Exception;
using CoreBridgeCRM.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoreBridgeCRM.Api.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if(context.Exception is CoreBridgeCRMException)
        {
            HandleProjectException(context);
        }
        else
        {
            ThrowUnkowError(context);
        }
    }

    private void HandleProjectException(ExceptionContext context)
    {
        var CoreBridgeCRMException = (CoreBridgeCRMException)context.Exception;
        var errorResponse = new ResponseErrorJson(CoreBridgeCRMException.GetErrors());

        context.HttpContext.Response.StatusCode = CoreBridgeCRMException.StatusCode;
        context.Result = new ObjectResult(errorResponse);
    }

    private void ThrowUnkowError(ExceptionContext context)
    {
        var errorResponse = new ResponseErrorJson(ResourceErrorMessages.UNKNOWN_ERROR);

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(errorResponse);
    }
}
