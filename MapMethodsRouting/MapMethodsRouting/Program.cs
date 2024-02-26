var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// If we have a multiple lines logic then we have to use routing 
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    // This is the Http context means when i'am going to hit a URL all the things like methods, properties will come inside context

    endpoints.MapGet("/Home", async (context) =>
    // The below is alled request delegate
    {
        await context.Response.WriteAsync("This is Home Page ... GET");
    });

    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page ... POST");
    });

    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page ... PUT");
    });

    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page ... DELETE");
    });




});





// This is delegate in .net but in JS it is call back func()
//app.Map("/Home", () => "Hello World!");

//app.MapGet("/Home", () => "Hello World - GET");
//app.MapPost("/Home", () => "Hello World - POST");
//app.MapPut("/Home", () => "Hello World - PUT");
//app.MapDelete("/Home", () => "Hello World - DELETE");

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page Not Found.. ");
});
