var builder = WebApplication.CreateBuilder(args);

// Controller and Routing ke saat Controller or Voews ki setting mil jati he
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Imp Middleware for using Client-Side-lib in our app
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
