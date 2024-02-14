var builder = WebApplication.CreateBuilder(args);

//Adding service to use controller so now the service reference added to app
builder.Services.AddControllersWithViews();


var app = builder.Build();


// This is also routing but not the in write way
//app.MapGet("/", () => "Hello World!");



// 1
// So by default HomeController Index action() will run
//app.MapDefaultControllerRoute();



// 2
// This is our router tempelate
app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}",
    pattern: "{controller=Home}/{action=About}/{id?}"
    //pattern: "{controller=User}/{action=Index}/{id?}"

    );

//3
// Attribute Based Routing
app.MapControllers();


app.Run();
