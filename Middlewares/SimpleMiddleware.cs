namespace Minimal_API;

public class SimpleMiddleware
{
    private readonly RequestDelegate _next;

    public SimpleMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine("Request is going to the Minimal API"+context.Request.Method +"   " + context.Request.Path);

        await _next(context);

        Console.WriteLine("Response is coming from the Minimal API" + context.Response.StatusCode);
    }
    
    
    
}