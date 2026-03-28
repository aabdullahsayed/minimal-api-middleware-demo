using Minimal_API;
using Minimal_API.Endpoints;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

//Registering Middleware 
app.UseMiddleware<SimpleMiddleware>();
app.UseMiddleware<ExceptionMiddleware>();

app.MapEndpoints();

app.Run();
