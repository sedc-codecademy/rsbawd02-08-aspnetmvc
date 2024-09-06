using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DemoFilterAnsMiddleware.Filters
{
    public class LogFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Action finished");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("FROM FILTER " + context.HttpContext.Request.GetDisplayUrl());            
        }
    }
}
