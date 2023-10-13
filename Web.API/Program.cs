using Application.Library.DatabaseContext;
using Application.Library.Patterns.UnitOfWork;
using Infrastructure.Library.DatabaseContextDb;
using Infrastructure.Library.Pattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Web.API.Authentication;
using Web.API.Configuration.Cache;

var builder = WebApplication.CreateBuilder(args);



//  Access To Appsetting.json
ConfigurationManager configuration = builder.Configuration;

//  Database Context
builder.Services.AddScoped<IFacadPattern, FacadPattern>();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));
//builder.Services.AddEntityFrameworkSqlServer().AddDbContext<DatabaseContext>(option => option.UseSqlServer(configuration.GetConnectionString("Local")));

//  Identity Services Authorization Authentication Accounting
builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
{
    x.Password.RequiredLength = 8;
})
.AddEntityFrameworkStores<ApplicationDatabase>()
.AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "";
    x.LogoutPath = "";
});
// Add services to the container.
builder.Services.AddControllers();

//  Injection
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICacheRepositories, CacheServices>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Architecture",
        Version = "v1",
        Description = "Clean Architecture Domain Drive Design Patter",
        TermsOfService = new Uri("https://github.com/Tajerbashi/Architecture"),
        Contact = new OpenApiContact
        {
            Name = "Kamran Tajerbashi",
            Email = "kamrantajerbashi@gmail.com",
            Url = new Uri("https://github.com/KTajerbashi"),
        },
        License = new OpenApiLicense
        {
            Name = "Tajerbashi Company On Git Hub",
            Url = new Uri("https://github.com/Tajerbashi"),
        }
    });
});
//  Caching
builder.Services.AddMemoryCache(c =>
{
    c.SizeLimit = 1000;
});

builder.Services.AddDistributedMemoryCache(s =>
{
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseStaticFiles();
}
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
