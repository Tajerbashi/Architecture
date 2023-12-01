var welcomeText = @"
========================================================================================
====================    Hello, Welcome To OpenID Identity Server    ====================
========================================================================================
";
//  Service
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
//builder.Services.AddIdentityServer()


//  MiddleWare
var app = builder.Build();
app.MapGet("/", () => welcomeText);
app.Run();
