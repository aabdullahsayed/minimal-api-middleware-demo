namespace Minimal_API.Endpoints;

public static class ProductEndpoints
{
    public static void MapEndpoints(this WebApplication app)
    {

        app.MapGet("/", () =>
        {
            Console.WriteLine("its on the Minimal API");
            return "Hello from the minimal api response";
    
        });

        //this is for testing the ExceptionMiddleware

        app.MapGet("/api/test-error", () => 
        {
            throw new Exception("Boom! This is a test crash.");
        });

    }
    
}