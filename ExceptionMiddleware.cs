namespace Minimal_API;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    
    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {

        try
        {
            await _next(context);
        }
        catch (Exception e)
        {
            await HandleError(context, e);
        }
        
        
    }

    public static Task HandleError(HttpContext context, Exception e)
    {

        context.Response.StatusCode = 500;

        var error = new
        {
            message = "Something went wrong on our end", details = e.Message
        };

        return context.Response.WriteAsJsonAsync(error);
        
    }
    
    
}