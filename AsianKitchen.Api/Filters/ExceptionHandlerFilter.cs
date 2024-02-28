using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AsianKitchen.Api.Filters;

public class ExceptionHandlerFilterAttribute:ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        var errorResult = new ObjectResult(new {error = "An error occurred while processing request."})
        {
           StatusCode = (int)HttpStatusCode.InternalServerError
        };

        context.Result = errorResult;

        context.ExceptionHandled = true;
    }
}