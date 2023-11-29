var welcomeText = @"
========================================================================================
====================    Hello, Welcome To OpenID Identity Server    ====================
========================================================================================
";

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => welcomeText);

app.Run();
