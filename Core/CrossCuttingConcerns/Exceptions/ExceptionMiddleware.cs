using Core.CrossCuttingConcerns.Exceptions.Handles;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly HttpExceptionHandler _httpExceptionHandler;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next; //controllerdan gelen get,post,put gibi isteklerin delegesi
            _httpExceptionHandler = new HttpExceptionHandler();

        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context); //controllerdan gelen requesti çalıştır
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context.Response, exception); //contexten gelen yanıt ve exception metda gönder
            }

        }
        private Task HandleExceptionAsync(HttpResponse response, Exception exception)
        {
            response.ContentType = "application/json";
            _httpExceptionHandler.Response = response;
            return _httpExceptionHandler.HandleExceptionAsync(exception);
        }
    }
}
