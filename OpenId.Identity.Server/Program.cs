using Microsoft.Extensions.DependencyInjection;
using OpenId.Identity.Server.Resources.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();
builder.Services.AddIdentityServer()
    .AddDeveloperSigningCredential()
    .AddTestUsers(Configs.GetUsers())
    .AddInMemoryIdentityResources(Configs.GetIdentityResources())
    .AddInMemoryClients(Configs.GetClients())
    //.AddInMemoryApiResources()
    ;
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseIdentityServer();
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();
app.Run();
