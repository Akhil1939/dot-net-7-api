using API.Response;
using Newtonsoft.Json;
using System.Net;

namespace A_P_I.Middlewares
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch(Exception ex) { 
                await HandleExceptionAsync(context,  ex);

            }
        }

        public async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            ErrorApiResponse response = GenerateErrorApiResponse(context, ex);
            string jsonResponse = JsonConvert.SerializeObject(response);
            await context.Response.WriteAsync(jsonResponse);
        }

        public ErrorApiResponse GenerateErrorApiResponse(HttpContext context, Exception ex)
        {
            List<string> messageList = new();
            messageList.Add(ex.Message);
            (int httpStatusCode, List<string> messages, Dictionary<string, object>? metadata) = (500,messageList, null);

            context.Response.StatusCode = httpStatusCode;

            return new ErrorApiResponse()
            {
                Success = false,
                HttpStatusCode = httpStatusCode,
                Messages = messages,
                Metadata = metadata
            };
        }

    }
}
