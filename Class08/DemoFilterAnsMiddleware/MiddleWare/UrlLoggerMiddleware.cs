using Microsoft.AspNetCore.Http.Extensions;

namespace DemoFilterAnsMiddleware.MiddleWare
{
    public class UrlLoggerMiddleware
    {
        private readonly RequestDelegate _next;
        public UrlLoggerMiddleware(RequestDelegate requestDelegate)
        {
                
            _next = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context) {

            Console.WriteLine("FROM MIDLLEWARE " + context.Request.GetDisplayUrl());
            await _next(context);
        
        }
    }
}
