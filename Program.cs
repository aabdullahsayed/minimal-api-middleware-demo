using Minimal_API;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

//Registering Middleware 
app.UseMiddleware<SimpleMiddleware>();
app.UseMiddleware<ExceptionMiddleware>();

//Minimal API's

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

app.Run();
