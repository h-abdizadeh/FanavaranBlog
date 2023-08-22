var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


var app = builder.Build();
app.UseRouting();
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=home}/{action=index}/{id?}");
});


app.Run();
