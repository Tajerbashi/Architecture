using Infrastructure.Library.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



//  Access To Appsetting.json
ConfigurationManager configuration = builder.Configuration;
var ctr = configuration.GetConnectionString("DatabaseLocal");
builder.Services.AddDbContext<DatabaseContext>(
        option => option.UseSqlServer(configuration.GetConnectionString("DatabaseLocal")));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
