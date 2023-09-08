using Application.Library.DatabaseContext;
using Application.Library.Patterns.UnitOfWork;
using Infrastructure.Library.DatabaseContextDb;
using Infrastructure.Library.Pattern;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);



//  Access To Appsetting.json
ConfigurationManager configuration = builder.Configuration;


builder.Services.AddScoped<IFacadPattern, FacadPattern>();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("Local")));
//builder.Services.AddEntityFrameworkSqlServer().AddDbContext<DatabaseContext>(option => option.UseSqlServer(configuration.GetConnectionString("Local")));

// Add services to the container.
builder.Services.AddControllers();

//  Injection
builder.Services.AddScoped<IUnitOfWork, UnitOfWork > ();

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
    // Set the comments path for the Swagger JSON and UI.
    //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    ////var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    //c.IncludeXmlComments(xmlPath);
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

app.UseAuthorization();

app.MapControllers();

app.Run();
