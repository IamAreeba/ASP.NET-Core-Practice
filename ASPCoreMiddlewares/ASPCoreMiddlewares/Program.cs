var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// Request pipeline

//app.MapGet("/", () => "Hello World!");


// 01

/*
    To define middle wares we use Run()
    context: To handle http request. It is derive from HttpContext
    This call back func is middleware created through Run()
    For every request eg. /Home, /About the below middleware will run
    We have to do this thing cuz we put logic here to check every request
        
*/
/*
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Welcome to ASP.NET Core MVC 06");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Programentor");
});
*/




// 02
/* 
    Order of middleware is very important
    Only 1 middle ware is running cuz we have used Run()
    Run method never exe next/subsequent middleware. Why ? 
    Cuz Run doesnt have the concept of "next". We'll use "Use()"
    Use: If u want your middlewares to pass through multiple middlewares
 
 */

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync(".NET Core \n");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Areeba Mentor");
});


// 03
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello Viewers... \n");
    // We can write after this but it will run when sending response
    await next(context);
});


app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Welcome to ASP.NET Core 6 \n");
    await next(context);

});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Its Areeba");
});

// At this line our app actually start and hosted on server
app.Run();
 