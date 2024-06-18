using System.Net;

namespace behsoftbolao.api.Middlewares;

public class ExceptionHandlerMiddleware
{
    private readonly ILogger<ExceptionHandlerMiddleware> _logger;
    private readonly RequestDelegate _next;

    public ExceptionHandlerMiddleware(ILogger<ExceptionHandlerMiddleware> logger, RequestDelegate next)
    {
        this._logger = logger;
        this._next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            var errorId = Guid.NewGuid();

            // Log exception
            _logger.LogError(ex, $"{errorId} : {ex.Message}");

            // Return a custom error Response
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var error = new
            {
                Id = errorId,
                ErrorMessage = "Something went wrong! We are looking into resolving this."
            };

            await context.Response.WriteAsJsonAsync(error);
        }
    }


}
