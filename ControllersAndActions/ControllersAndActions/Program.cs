var builder = WebApplication.CreateBuilder(args);

// Adding service to provide routing for Controller nd views
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"

    );


//app.MapGet("/", () => "Hello World!");

app.Run();
