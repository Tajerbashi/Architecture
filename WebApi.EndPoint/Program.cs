using Infrastructure.Library.Database.EF;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<ApplicationContext>(sql => sql.UseSqlServer(configuration.GetConnectionString("ConnectionString")));
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));
//  Authentication Services
builder.Services.AddAuthentication(option =>
{
    option.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(
    option =>
    {
        option.LoginPath = new PathString("/Authentication/Signin");
        option.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
        option.AccessDeniedPath = new PathString("/Authentication/Signin");
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();