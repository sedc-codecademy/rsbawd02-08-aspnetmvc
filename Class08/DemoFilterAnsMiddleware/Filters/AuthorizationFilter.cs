using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DemoFilterAnsMiddleware.Filters
{
    public class AuthorizationFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Query.ContainsKey("apiKey"))
            {
                var apiKey = context.HttpContext.Request.Query["apiKey"];

                


                if (apiKey == "abc")
                    return;
            }

            context.Result = new BadRequestObjectResult("you need api key");
        }
    }
}
