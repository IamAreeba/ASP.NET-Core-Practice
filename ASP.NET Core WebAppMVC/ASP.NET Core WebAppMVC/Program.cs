

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
// If app env is suitable for dev then go else below code
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// Below are middleware. Consider them as a pipeline. User request pass through all of the middleware

// If we have to display images in our app we use below middleware
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    // Routing pattern
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
