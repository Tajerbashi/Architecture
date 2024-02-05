using Application.Library.Repositories.SEC;
using AutoMapper;
using Infrastructure.Library.AutoMapper;
using Infrastructure.Library.Database.EF;
using Infrastructure.Library.Services.SEC.UserServices;
using Microsoft.EntityFrameworkCore;
using WebApi.Hubs;
using IoC.ServiceInjectors;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServiceExtentions();
ConfigurationManager configuration = builder.Configuration;


var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserRepository, UserService>();
builder.Services.AddSignalR();
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
app.MapHub<ChatRoomHub>("/ChatHub");
app.Run();
